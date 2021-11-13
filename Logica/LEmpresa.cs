using Datos;
using Entidades;
using System.Collections.Generic;
using System.Linq;


namespace Logica
{
    public class LEmpresa
    {

        private Sgsst controlador = new Sgsst();
        public Empresa Get(int id) {

            return this.controlador.empresas.Where(x => x.Id == id).FirstOrDefault();

        }

        public void Crear(Empresa empresa) {

            Crud.Insertar(empresa);

        }

        //Brigada

        public List<TipoBrigada> GetBrigadas() {

            return this.controlador.tiposBrigada.ToList();

        }

        public TipoBrigada GetBrigada(int id){

            return this.controlador.tiposBrigada.Where(x => x.Id == id).FirstOrDefault();

        }

    }

}
