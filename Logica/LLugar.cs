using Datos;
using Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LLugar
    {

        private Sgsst controlador = new Sgsst();

        public List<Lugar> GetLugares(Empresa empresa) {

            return this.controlador.lugares.Where(x => x.IdEmpresa == empresa.Id).ToList();

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

    }
}
