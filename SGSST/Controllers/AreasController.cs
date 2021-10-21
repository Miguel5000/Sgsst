using Entidades;
using Logica;
using SGSST.Utilidades;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SGSST.Controllers
{
    public class AreasController : ApiController
    {

        private LArea logicaArea = new LArea();

        [HttpPost]
        public HttpResponseMessage GetAreas(HttpRequestMessage request, [FromBody] Empresa empresa)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            List<Area> areas = logicaArea.GetAreas(empresa);

            if (areas.Count == 0) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, areas);

        }

        [HttpPost]
        public HttpResponseMessage Crear(HttpRequestMessage request, [FromBody] Area area)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaArea.Crear(area);
            return new HttpResponseMessage(HttpStatusCode.Created);

        }

        [HttpPut]
        public HttpResponseMessage Editar(HttpRequestMessage request, [FromBody] Area area)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaArea.Editar(area);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        [HttpDelete]
        public HttpResponseMessage Eliminar(HttpRequestMessage request, [FromBody] Area area)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaArea.Eliminar(area);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }

    }
}