using Entidades;
using Logica;
using SGSST.Utilidades;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SGSST.Controllers
{
    public class ActasController : ApiController
    {

        private LActa logicaActa = new LActa();

        public class PaqueteGetActas { 
        
            public GrupoSgsst Grupo { get; set; }
            public TipoActa TipoActa { get; set; }
            public Empresa Empresa { get; set; }

        }

        [HttpPost]
        public HttpResponseMessage GetActas(HttpRequestMessage request, [FromBody]PaqueteGetActas paquete)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            List<Acta> actas = logicaActa.GetActas(paquete.Grupo, paquete.TipoActa, paquete.Empresa);

            if (actas.Count == 0) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, actas);

        }

        [HttpGet]
        public HttpResponseMessage Get(HttpRequestMessage request, int id)
        {

            Acta acta = logicaActa.Get(id);

            if (acta == null) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, acta);

        }


        [HttpPost]
        public HttpResponseMessage Crear(HttpRequestMessage request, [FromBody]Acta acta)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaActa.Crear(acta);
            return new HttpResponseMessage(HttpStatusCode.Created);

        }

        [HttpPut]
        public HttpResponseMessage Editar(HttpRequestMessage request, [FromBody] Acta acta)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaActa.Editar(acta);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        [HttpDelete]
        public HttpResponseMessage Eliminar(HttpRequestMessage request, [FromBody] Acta acta)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaActa.Eliminar(acta);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        [HttpGet]
        public HttpResponseMessage GetTipo(HttpRequestMessage request, int id)
        {

            TipoActa tipo = logicaActa.GetTipo(id);

            if (tipo == null) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, tipo);

        }

        //Subtemas

        [HttpPost]
        public HttpResponseMessage GetSubtemas(HttpRequestMessage request, [FromBody] Acta acta)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            List<Subtema> subtemas = logicaActa.GetSubtemas(acta);

            if (subtemas.Count == 0) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, subtemas);

        }

        [HttpPost]
        public HttpResponseMessage CrearSubtema(HttpRequestMessage request, [FromBody] Subtema subtema)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaActa.CrearSubtema(subtema);
            return new HttpResponseMessage(HttpStatusCode.Created);

        }

        [HttpPut]
        public HttpResponseMessage EditarSubtema(HttpRequestMessage request, [FromBody] Subtema subtema)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaActa.EditarSubtema(subtema);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        [HttpDelete]
        public HttpResponseMessage EliminarSubtema(HttpRequestMessage request, [FromBody] Subtema subtema)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaActa.EliminarSubtema(subtema);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        //Asistencias

        [HttpPost]
        public HttpResponseMessage GetAsistencias(HttpRequestMessage request, [FromBody] Acta acta)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            List<Usuario> usuarios = logicaActa.GetAsistencias(acta);

            if (usuarios.Count == 0) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, usuarios);

        }

        [HttpPost]
        public HttpResponseMessage CrearAsistencia(HttpRequestMessage request, [FromBody] Asistencia asistencia)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaActa.CrearAsistencia(asistencia);
            return new HttpResponseMessage(HttpStatusCode.Created);

        }

        [HttpPut]
        public HttpResponseMessage EditarAsistencia(HttpRequestMessage request, [FromBody] Asistencia asistencia)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaActa.EditarAsistencia(asistencia);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        [HttpDelete]
        public HttpResponseMessage EliminarAsistencia(HttpRequestMessage request, [FromBody] Asistencia asistencia)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaActa.EliminarAsistencia(asistencia);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }

    }
}