using Entidades;
using Logica;
using SGSST.Utilidades;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SGSST.Controllers
{
    public class PqrsController : ApiController
    {

        private LPqrs logicaPqrs = new LPqrs();

        [HttpPost]
        public HttpResponseMessage GetListaPqrs(HttpRequestMessage request, [FromBody] Empresa empresa)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            List<Pqrs> listaPqrs = logicaPqrs.GetListaPqrs(empresa);

            if (listaPqrs.Count == 0) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, listaPqrs);

        }

        [HttpPost]
        public HttpResponseMessage GetListaPqrs(HttpRequestMessage request, [FromBody] Usuario usuario)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            List<Pqrs> listaPqrs = logicaPqrs.GetListaPqrs(usuario);

            if (listaPqrs.Count == 0) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, listaPqrs);

        }

        [HttpGet]
        public HttpResponseMessage Get(HttpRequestMessage request, int id)
        {

            Pqrs pqrs = logicaPqrs.Get(id);

            if (pqrs == null) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, pqrs);

        }

        [HttpPost]
        public HttpResponseMessage Crear(HttpRequestMessage request, [FromBody] Pqrs pqrs)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            logicaPqrs.Crear(pqrs);
            return new HttpResponseMessage(HttpStatusCode.Created);

        }

        [HttpGet]
        public HttpResponseMessage GetTipos(HttpRequestMessage request)
        {

            List<TipoPqrs> tipos = logicaPqrs.GetTipos();

            if (tipos.Count == 0) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, tipos);

        }

    }
}