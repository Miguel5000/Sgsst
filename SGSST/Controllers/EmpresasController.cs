using Entidades;
using Logica;
using SGSST.Utilidades;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SGSST.Controllers
{
    public class EmpresasController : ApiController
    {

        private LEmpresa logicaEmpresa = new LEmpresa();

        [HttpGet]
        public HttpResponseMessage Get(HttpRequestMessage request, int id)
        {

            Empresa empresa = logicaEmpresa.Get(id);

            if (empresa == null) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, empresa);

        }

        [HttpPost]
        public HttpResponseMessage Crear(HttpRequestMessage request, [FromBody] Empresa empresa)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaEmpresa.Crear(empresa);
            return new HttpResponseMessage(HttpStatusCode.Created);

        }

        //Brigada

        [HttpGet]
        public HttpResponseMessage GetBrigadas(HttpRequestMessage request)
        {

            List<TipoBrigada> brigadas = logicaEmpresa.GetBrigadas();

            if (brigadas.Count == 0) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, brigadas);

        }

        [HttpGet]
        public HttpResponseMessage GetBrigada(HttpRequestMessage request, int id)
        {

            TipoBrigada brigada = logicaEmpresa.GetBrigada(id);

            if (brigada == null) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, brigada);

        }

    }
}