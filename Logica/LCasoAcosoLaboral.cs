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

            throw new NotImplementedException();

        }

        public void Crear(CasoAcosoLaboral caso) {

            throw new NotImplementedException();

        }

        public EstadoCaso GetEstado(int id) {

            throw new NotImplementedException();

        }

        public List<CausaCaso> GetCausas() {

            throw new NotImplementedException();

        }

        public void CrearInvolucrado(InvolucradosEnCaso involucracion) {

            throw new NotImplementedException();

        }

    }
}
