using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Logica
{
    public class LEmpresa
    {
        private Mapeo mapeo = new Mapeo();
        public Empresa Get(int id) {

            throw new NotImplementedException();

        }

        public void Crear(Empresa empresa) {

            throw new NotImplementedException();

        }

        //Brigada

        public List<TipoBrigada> GetBrigadas() {

            return mapeo.tiposBrigada.ToList();
            //throw new NotImplementedException();

        }

        public TipoBrigada GetBrigada(int id){

            throw new NotImplementedException();

        }

    }

}
