using Entidades;
using Logica;
using SGSST.Utilidades;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SGSST.Controllers
{
    public class LugaresController : ApiController
    {

        private LLugar logicaLugar = new LLugar();

        [HttpGet]
        public HttpResponseMessage Get(HttpRequestMessage request, int id)
        {

            Lugar lugar = logicaLugar.Get(id);

            if (lugar == null) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, lugar);

        }

        [HttpPost]
        public HttpResponseMessage GetLugar(HttpRequestMessage request, [FromBody] Acta acta)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            Lugar lugar = logicaLugar.Get(acta);

            if (lugar == null) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, lugar);

        }

        [HttpPost]
        public HttpResponseMessage GetLugares(HttpRequestMessage request, [FromBody] Empresa empresa)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            List<Lugar> lugares = logicaLugar.GetLugares(empresa);

            if (lugares.Count == 0) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, lugares);

        }

        [HttpPost]
        public HttpResponseMessage Crear(HttpRequestMessage request, [FromBody] Lugar lugar)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaLugar.Crear(lugar);
            return new HttpResponseMessage(HttpStatusCode.Created);

        }

        [HttpPut]
        public HttpResponseMessage Editar(HttpRequestMessage request, [FromBody] Lugar lugar)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaLugar.Editar(lugar);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        [HttpDelete]
        public HttpResponseMessage Eliminar(HttpRequestMessage request, [FromBody] Lugar lugar)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            logicaLugar.Eliminar(lugar);
            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        [HttpPost]
        public HttpResponseMessage IsAgregable(HttpRequestMessage request, [FromBody] Lugar lugar)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            bool respuesta = logicaLugar.IsAgregable(lugar);
            return request.CreateResponse(HttpStatusCode.OK, respuesta);

        }

        [HttpPost]
        public HttpResponseMessage IsEliminable(HttpRequestMessage request, [FromBody] Lugar lugar)
        {

            HttpResponseMessage validacion = Validador.Validar(request, ModelState);

            if (validacion != null) return validacion;

            bool respuesta = logicaLugar.IsEliminable(lugar);
            return request.CreateResponse(HttpStatusCode.OK, respuesta);

        }


    }
}