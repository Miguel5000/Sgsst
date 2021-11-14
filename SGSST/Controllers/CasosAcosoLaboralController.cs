using Entidades;
using Logica;
using SGSST.Utilidades;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SGSST.Controllers
{
    public class CasosAcosoLaboralController : ApiController
    {

        private LCasoAcosoLaboral logicaCasos = new LCasoAcosoLaboral();

        [HttpPost]
        public HttpResponseMessage GetCasosDeEmpresa(HttpRequestMessage request, [FromBody] Empresa empresa)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            List<CasoAcosoLaboral> casos = logicaCasos.GetCasos(empresa);

            if (casos.Count == 0) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, casos);

        }

        [HttpPost]
        public HttpResponseMessage GetCasosDeUsuario(HttpRequestMessage request, [FromBody] Usuario usuario)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            List<CasoAcosoLaboral> casos = logicaCasos.GetCasos(usuario);

            if (casos.Count == 0) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, casos);

        }

        [HttpGet]
        public HttpResponseMessage Get(HttpRequestMessage request, int id)
        {

            CasoAcosoLaboral caso = logicaCasos.Get(id);

            if (caso == null) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, caso);

        }

        [HttpPost]
        public HttpResponseMessage Crear(HttpRequestMessage request, [FromBody] CasoAcosoLaboral caso)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaCasos.Crear(caso);

            return request.CreateResponse(HttpStatusCode.Created, caso);
        }

        [HttpGet]
        public HttpResponseMessage GetEstado(HttpRequestMessage request, int id)
        {

            EstadoCaso estado = logicaCasos.GetEstado(id);

            if (estado == null) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, estado);

        }

        [HttpGet]
        public HttpResponseMessage GetCausa(HttpRequestMessage request, int id)
        {

            CausaCaso causa = logicaCasos.GetCausa(id);

            if (causa == null) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, causa);

        }

        [HttpGet]
        public HttpResponseMessage GetCausas(HttpRequestMessage request)
        {

            List<CausaCaso> causas = logicaCasos.GetCausas();

            if (causas.Count == 0) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, causas);

        }

        [HttpPost]
        public HttpResponseMessage CrearInvolucrado(HttpRequestMessage request, [FromBody] InvolucradosEnCaso involucracion)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaCasos.CrearInvolucrado(involucracion);
            return new HttpResponseMessage(HttpStatusCode.Created);

        }

        [HttpGet]
        public HttpResponseMessage GetInvolucraciones(HttpRequestMessage request, int id)
        {

            List<InvolucradosEnCaso> involucraciones = logicaCasos.GetInvolucraciones(id);

            if (involucraciones.Count == 0) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, involucraciones);

        }

    }
}