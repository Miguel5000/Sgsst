using Entidades;
using Logica;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SGSST.Controllers
{
    public class GruposSgsstController : ApiController
    {

        private LGrupoSgsst logicaGrupo = new LGrupoSgsst();

        [HttpGet]
        public HttpResponseMessage GetGrupos(HttpRequestMessage request)
        {

            List<GrupoSgsst> grupos = logicaGrupo.GetGrupos();

            if (grupos.Count == 0) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, grupos);

        }

        [HttpGet]
        public HttpResponseMessage Get(HttpRequestMessage request, int id)
        {

            GrupoSgsst grupo = logicaGrupo.Get(id);

            if (grupo == null) return new HttpResponseMessage(HttpStatusCode.NotFound);

            return request.CreateResponse(HttpStatusCode.OK, grupo);

        }

    }
}