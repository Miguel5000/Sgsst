using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void GenerarToken(Usuario usuario) {

            throw new NotImplementedException();

        }

        public void EnviarCorreo(Usuario usuario)
        {

            throw new NotImplementedException();

        }

    }
}
