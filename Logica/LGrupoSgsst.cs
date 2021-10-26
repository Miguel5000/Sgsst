using Datos;
using Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LGrupoSgsst
    {

        public List<GrupoSgsst> GetGrupos() {

            return Sgsst.GetControlador().grupos.ToList();

        }

        public GrupoSgsst Get(int id) {

            return Sgsst.GetControlador().grupos.Where(x => x.Id == id).FirstOrDefault();

        }

    }
}
