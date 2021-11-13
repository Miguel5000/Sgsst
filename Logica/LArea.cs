using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LArea
    {

        private Sgsst controlador = new Sgsst();

        public List<Area> GetAreas(Empresa empresa) {

            return this.controlador.areas.Where(x => x.IdEmpresa == empresa.Id).ToList();

        }

        public void Crear(Area area) {

            Crud.Insertar(area);

        }

        public void Editar(Area area)
        {

            Crud.Actualizar(area);

        }

        public void Eliminar(Area area)
        {

            Crud.Eliminar(area);

        }

    }
}
