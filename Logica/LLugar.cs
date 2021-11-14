using Datos;
using Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LLugar
    {

        private Sgsst controlador = new Sgsst();

        public Lugar Get(int id) {

            return this.controlador.lugares.Where(x => x.Id == id).FirstOrDefault();
        
        }

        public List<Lugar> GetLugares(Empresa empresa) {

            return this.controlador.lugares.Where(x => x.IdEmpresa == empresa.Id).ToList();

        }

        public Lugar Get(Acta acta) {

            return this.controlador.lugares.Where(x => x.Id == acta.IdLugar).FirstOrDefault();

        }

        public void Crear(Lugar lugar) {

            Crud.Insertar(lugar);

        }

        public void Editar(Lugar lugar)
        {

            Crud.Actualizar(lugar);

        }

        public void Eliminar(Lugar lugar)
        {

            Crud.Eliminar(lugar);

        }

        public bool IsAgregable(Lugar lugar) {

            return (this.controlador.lugares.Where(x => x.IdEmpresa == lugar.IdEmpresa && x.Nombre == lugar.Nombre).Count() > 0) ? false : true;
        
        }

        public bool IsEliminable(Lugar lugar) {

            return (this.controlador.actas.Where(x => x.IdLugar == lugar.Id).Count() > 0) ? false : true;

        }

    }
}
