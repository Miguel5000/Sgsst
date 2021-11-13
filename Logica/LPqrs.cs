using Datos;
using Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LPqrs
    {

        private Sgsst controlador = new Sgsst();

        public List<Pqrs> GetListaPqrs(Empresa empresa) {

            return controlador.pqrs.Where(x => x.IdEmpresa == empresa.Id).ToList();

        }

        public List<Pqrs> GetListaPqrs(Usuario usuario)
        {

            return this.controlador.pqrs.Where(x => x.IdUsuario == usuario.Id).ToList();

        }

        public Pqrs Get(int id) {

            return this.controlador.pqrs.Where(x => x.Id == id).FirstOrDefault();

        }

        public void Crear(Pqrs pqrs)
        {

            Crud.Insertar(pqrs);

        }

        public List<TipoPqrs> GetTipos() {

            return this.controlador.tiposPqrs.ToList();

        }

    }
}
