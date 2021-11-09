﻿using Datos;
using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace Logica
{
    public class LUsuario
    {
        private static string EMPLEADO = "Empleado";

        public List<Usuario> GetEmpleados(Empresa empresa)
        {

            return Sgsst.GetControlador().usuarios.Where(x => x.IdEmpresa == empresa.Id).
                Join(Sgsst.GetControlador().roles,
                usuario => usuario.IdRol,
                rol => rol.Id,
                (usuario, rol) => new { u = usuario, r = rol }).
                Where(y => y.r.Nombre == LUsuario.EMPLEADO).
                Select(z => z.u).ToList();

        }

        public Usuario Get(Usuario usuario)
        {

            return Sgsst.GetControlador().usuarios.Where(x => x.Correo == usuario.Correo && x.Clave == usuario.Clave).FirstOrDefault();

        }

        public Usuario Get(string token)
        {

            return Sgsst.GetControlador().usuarios.Where(x => x.TokenRecuperarClave == token).FirstOrDefault();

        }

        public void GenerarUsuarios(byte[] archivo)
        {

            throw new NotImplementedException();

        }

        public void Crear(Usuario usuario) {

            Crud.Insertar(usuario);

        }

        public void CambiarClave(Usuario usuario)
        {

            Crud.Actualizar(usuario);

        }

        public void Eliminar(Usuario usuario) {

            Crud.Eliminar(usuario);

        }

        public Rol GetRol(Usuario usuario)
        {

            return Sgsst.GetControlador().roles.Where(x => x.Id == usuario.IdRol).FirstOrDefault();

        }

        public void GenerarToken(string correo) {

            Usuario usuario = BuscarCorreo(correo);
            usuario.TokenRecuperarClave = encriptar(JsonConvert.SerializeObject(usuario));

            Crud.Actualizar(usuario);
            String mensaje = "Usted ha solicitado un cambio de su contraseña en SGSST APP,su token de recuperacion es" + usuario.TokenRecuperarClave;
            EnviarCorreo(correo, mensaje);

        }
        public Usuario BuscarCorreo(string correo)
        {
            return Sgsst.GetControlador().usuarios.Where(x => x.Correo == correo).FirstOrDefault();
        }

        public void EnviarCorreo(string correo, string mensaje)
        {
            //Configuración del Mensaje
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            //Especificamos el correo desde el que se enviará el Email y el nombre de la persona que lo envía
            mail.From = new MailAddress("sgsstapp3@gmail.com", "EMPRESA S.A.S");

            //Aquí ponemos el asunto del correo
            mail.Subject = "Cambio de si contraseña";
            //Aquí ponemos el mensaje que incluirá el correo
            mail.Body = mensaje;
            //Especificamos a quien enviaremos el Email, no es necesario que sea Gmail, puede ser cualquier otro proveedor
            mail.To.Add(correo);

            SmtpServer.Port = 587; //Puerto que utiliza Gmail para sus servicios
                                   //Especificamos las credenciales con las que enviaremos el mail
            SmtpServer.Credentials = new System.Net.NetworkCredential("sgsstapp3@gmail.com", "sgsst123");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);

        }
        private string encriptar(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }

    }
}
