using Datos;
using Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LGrupoSgsst
    {
        private Sgsst controlador = new Sgsst();

        public List<GrupoSgsst> GetGrupos() {

            return this.controlador.grupos.ToList();

        }

        public GrupoSgsst Get(int id) {

            return this.controlador.grupos.Where(x => x.Id == id).FirstOrDefault();

        }

    }
}
