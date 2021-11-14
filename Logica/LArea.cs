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

        public Area Get(int id)
        {

            return this.controlador.areas.Where(x => x.Id == id).FirstOrDefault();

        }

        public Area Get(Usuario usuario) {

            return this.controlador.areas.Where(x => x.Id == usuario.IdArea).FirstOrDefault();

        }

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

        public bool IsAgregable(Area area)
        {

            return (this.controlador.lugares.Where(x => x.IdEmpresa == area.IdEmpresa && x.Nombre == area.Nombre).Count() > 0) ? false : true;

        }

        public bool IsEliminable(Area area)
        {

            return (this.controlador.usuarios.Where(x => x.IdArea == area.Id).Count() > 0) ? false : true;

        }

    }
}
