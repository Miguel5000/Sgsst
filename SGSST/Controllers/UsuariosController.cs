using Entidades;
using Logica;
using Newtonsoft.Json.Linq;
using SGSST.Utilidades;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SGSST.Controllers
{
    public class UsuariosController : ApiController
    {

        private LUsuario logicaUsuario = new LUsuario();

        [HttpGet]
        public HttpResponseMessage GetEmpleados(HttpRequestMessage request, Empresa empresa)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            List<Usuario> empleados = logicaUsuario.GetEmpleados(empresa);

            if (empleados.Count == 0) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, empleados);

        }

        [HttpPost]
        public HttpResponseMessage IniciarSesion(HttpRequestMessage request, [FromBody] Usuario usuario)
        {

            Usuario usuarioRespuesta = logicaUsuario.Get(usuario);

            if (usuarioRespuesta == null) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, usuarioRespuesta);

        }

        [HttpGet]
        public HttpResponseMessage Get(HttpRequestMessage request, string token)
        {

            Usuario usuario = logicaUsuario.GetToken(token);

            if (usuario == null) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, usuario);

        }

        [HttpPost]
        public HttpResponseMessage GenerarUsuarios(HttpRequestMessage request, [FromBody] byte[] archivo)
        {

            logicaUsuario.GenerarUsuarios(archivo);
            return new HttpResponseMessage(HttpStatusCode.Created);

        }

        [HttpPost]
        public HttpResponseMessage Crear(HttpRequestMessage request, [FromBody] Usuario usuario)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            usuario.IdRol = 3;
            usuario.IdArea = 4;
            logicaUsuario.Crear(usuario);
            return new HttpResponseMessage(HttpStatusCode.Created);

        }

        [HttpPut]
        public HttpResponseMessage CambiarClave(HttpRequestMessage request, [FromBody] JObject clave, string token)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;


            Usuario usuario = logicaUsuario.GetToken(token);
            usuario.Clave= clave["clave"].ToString();

            logicaUsuario.CambiarClave(usuario);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        [HttpPut]
        public HttpResponseMessage CambiarContrasena(HttpRequestMessage request, [FromBody] JObject datos)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

           
            string nombre = datos["nombre"].ToString();
            Usuario usuario = logicaUsuario.GetUsuario(nombre);
            usuario.Clave = datos["clave"].ToString();

            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        [HttpDelete]
        public HttpResponseMessage Eliminar(HttpRequestMessage request, [FromBody] Usuario usuario)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaUsuario.Eliminar(usuario);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        [HttpPost]
        public HttpResponseMessage GetRol(HttpRequestMessage request, [FromBody] Usuario usuario)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            Rol rol = logicaUsuario.GetRol(usuario);

            if (rol == null) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, rol);

        }

        [HttpPut]
        public HttpResponseMessage GenerarToken(HttpRequestMessage request, [FromBody] JObject correo)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            string correo1 = correo["correo"].ToString();
            logicaUsuario.GenerarToken(correo1);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }
    }
}