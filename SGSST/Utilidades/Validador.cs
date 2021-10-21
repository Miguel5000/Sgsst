using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.ModelBinding;

namespace SGSST.Utilidades
{
    public class Validador
    {

        public static HttpResponseMessage Validar(HttpRequestMessage request, ModelStateDictionary modelo) {

            if (!modelo.IsValid)
            {

                return request.CreateResponse(HttpStatusCode.BadRequest, modelo.Select(x => x.Value.Errors.Select(y => y.ErrorMessage)).ToList());

            }

            return null;

        }

    }
}