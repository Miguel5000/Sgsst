using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LCasoAcosoLaboral
    {

        public List<CasoAcosoLaboral> GetCasos(Empresa empresa) {

            return Sgsst.GetControlador().casos.Where(x => x.IdEmpresa == empresa.Id).ToList();

        }

        public List<CasoAcosoLaboral> GetCasos(Usuario usuario) {

            return Sgsst.GetControlador().casos.Where(x => x.IdCreador == usuario.Id).ToList();

        }

        public CasoAcosoLaboral Get(int id) {

            return Sgsst.GetControlador().casos.Where(x => x.Id == id).FirstOrDefault();

        }

        public void Crear(CasoAcosoLaboral caso) {

            Crud.Insertar(caso);

        }

        public EstadoCaso GetEstado(int id) {

            return Sgsst.GetControlador().estadosCaso.Where(x => x.Id == id).FirstOrDefault();

        }

        public List<CausaCaso> GetCausas() {

            return Sgsst.GetControlador().causas.ToList();

        }

        public void CrearInvolucrado(InvolucradosEnCaso involucracion) {

            Crud.Insertar(involucracion);

        }

    }
}
