using Datos;
using Entidades;
using System.Collections.Generic;
using System.Linq;


namespace Logica
{
    public class LEmpresa
    {
        public Empresa Get(int id) {

            return Sgsst.GetControlador().empresas.Where(x => x.Id == id).FirstOrDefault();

        }

        public void Crear(Empresa empresa) {

            Crud.Insertar(empresa);

        }

        //Brigada

        public List<TipoBrigada> GetBrigadas() {

            return Sgsst.GetControlador().tiposBrigada.ToList();

        }

        public TipoBrigada GetBrigada(int id){

            return Sgsst.GetControlador().tiposBrigada.Where(x => x.Id == id).FirstOrDefault();

        }

    }

}
