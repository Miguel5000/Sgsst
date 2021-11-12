using Entidades;
using Logica;
using Newtonsoft.Json.Linq;
using SGSST.Utilidades;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web;
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
            return request.CreateResponse(HttpStatusCode.Created, empresa);

        }

        [HttpPut]
        public HttpResponseMessage GuardarArchivo(HttpRequestMessage request, [FromBody] JObject usuario, string nombre)
        {

            JArray archivo = (JArray)usuario["archivo"];

            List<byte> bytesArchivo = new List<byte>();

            foreach (JToken byteArchivo in archivo)
            {

                bytesArchivo.Add(byte.Parse(byteArchivo.ToString()));

            }

            byte[] archivoASubir = bytesArchivo.ToArray();

            string ruta = HttpContext.Current.Server.MapPath("~//imagenes/") + nombre +"_logo.jpg";
            string rutaUrl = "https://localhost:44330" + "/imagenes/" + nombre + "_logo.jpg";

            FileStream fileStream = new FileStream(ruta, FileMode.Create, FileAccess.ReadWrite);
            fileStream.Write(archivoASubir, 0, archivoASubir.Length);
            fileStream.Close();

            return request.CreateResponse(HttpStatusCode.OK, rutaUrl);

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