using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LCasoAcosoLaboral
    {
        private Sgsst controlador = new Sgsst();

        public List<CasoAcosoLaboral> GetCasos(Empresa empresa) {

            return this.controlador.casos.Where(x => x.IdEmpresa == empresa.Id).ToList();

        }

        public List<CasoAcosoLaboral> GetCasos(Usuario usuario) {

            return this.controlador.casos.Where(x => x.IdCreador == usuario.Id).ToList();

        }

        public CasoAcosoLaboral Get(int id) {

            return this.controlador.casos.Where(x => x.Id == id).FirstOrDefault();

        }

        public void Crear(CasoAcosoLaboral caso) {

            Crud.Insertar(caso);

        }

        public EstadoCaso GetEstado(int id) {

            return this.controlador.estadosCaso.Where(x => x.Id == id).FirstOrDefault();

        }

        public List<CausaCaso> GetCausas() {

            return this.controlador.causas.ToList();

        }

        public void CrearInvolucrado(InvolucradosEnCaso involucracion) {

            Crud.Insertar(involucracion);

        }

    }
}
