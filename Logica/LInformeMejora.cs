using Datos;
using Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LInformeMejora
    {
        private Sgsst controlador = new Sgsst();

        public List<InformeMejora> GetInformes(int idEmpresa) {

            return this.controlador.informes.Where(x => x.IdEmpresa == idEmpresa && x.Publicacion == true).ToList();

        }

        public InformeMejora Get(int id) {

            return this.controlador.informes.Where(x => x.Id == id).FirstOrDefault();

        }

        public void Crear(InformeMejora informe) {

            Crud.Insertar(informe);

        }

        public void Editar(InformeMejora informe) {

            Crud.Actualizar(informe);

        }

        public InformeMejora GetUltimo()
        {
            return this.controlador.informes.Where(x => x.Publicacion == false).OrderByDescending(x => x.Id).FirstOrDefault();
        }

    }
}
