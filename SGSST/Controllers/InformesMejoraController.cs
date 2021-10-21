using Entidades;
using Logica;
using SGSST.Utilidades;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SGSST.Controllers
{
    public class InformesMejoraController : ApiController
    {
        private LInformeMejora logicaInforme = new LInformeMejora();

        [HttpPost]
        public HttpResponseMessage GetInformes(HttpRequestMessage request, [FromBody] Empresa empresa)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            List<InformeMejora> informes = logicaInforme.GetInformes(empresa);

            if (informes.Count == 0) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, informes);

        }

        [HttpGet]
        public HttpResponseMessage Get(HttpRequestMessage request, int id)
        {

            InformeMejora informe = logicaInforme.Get(id);

            if (informe == null) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, informe);

        }

        [HttpPost]
        public HttpResponseMessage Crear(HttpRequestMessage request, [FromBody] InformeMejora informe)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaInforme.Crear(informe);
            return new HttpResponseMessage(HttpStatusCode.Created);

        }

        [HttpPut]
        public HttpResponseMessage Editar(HttpRequestMessage request, [FromBody] InformeMejora informe)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaInforme.Editar(informe);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }
    }
}