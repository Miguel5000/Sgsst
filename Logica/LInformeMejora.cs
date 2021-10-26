using Datos;
using Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LInformeMejora
    {
        public List<InformeMejora> GetInformes(Empresa empresa) {

            return Sgsst.GetControlador().informes.Where(x => x.IdEmpresa == empresa.Id).ToList();

        }

        public InformeMejora Get(int id) {

            return Sgsst.GetControlador().informes.Where(x => x.Id == id).FirstOrDefault();

        }

        public void Crear(InformeMejora informe) {

            Crud.Insertar(informe);

        }

        public void Editar(InformeMejora informe) {

            Crud.Actualizar(informe);

        }

    }
}
