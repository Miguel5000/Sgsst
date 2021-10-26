using Datos;
using Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LPqrs
    {

        public List<Pqrs> GetListaPqrs(Empresa empresa) {

            return Sgsst.GetControlador().pqrs.Where(x => x.IdEmpresa == empresa.Id).ToList();

        }

        public List<Pqrs> GetListaPqrs(Usuario usuario)
        {

            return Sgsst.GetControlador().pqrs.Where(x => x.IdUsuario == usuario.Id).ToList();

        }

        public Pqrs Get(int id) {

            return Sgsst.GetControlador().pqrs.Where(x => x.Id == id).FirstOrDefault();

        }

        public void Crear(Pqrs pqrs)
        {

            Crud.Insertar(pqrs);

        }

        public List<TipoPqrs> GetTipos() {

            return Sgsst.GetControlador().tiposPqrs.ToList();

        }

    }
}
