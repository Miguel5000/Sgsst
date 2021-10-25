using Datos;
using Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LActa
    {

        public List<Acta> GetActas(GrupoSgsst grupo, TipoActa tipoActa, Empresa empresa) {

            return Sgsst.GetControlador().actas.Where(x => x.IdGrupo == grupo.Id && 
            x.IdTipo == tipoActa.Id && 
            x.IdEmpresa == empresa.Id).ToList();

        }

        public Acta Get(int id) {

            return Sgsst.GetControlador().actas.Where(x => x.Id == id).FirstOrDefault();

        }

        public void Crear(Acta acta) {

            Crud.Insertar(acta);

        }

        public void Editar(Acta acta) {

            Crud.Actualizar(acta);

        }

        public void Eliminar(Acta acta)
        {

            Crud.Eliminar(acta);

        }

        public TipoActa GetTipo(int id) {

            return Sgsst.GetControlador().tiposActa.Where(x => x.Id == id).FirstOrDefault();

        }

        //Subtemas

        public List<Subtema> GetSubtemas(Acta acta) {

            return Sgsst.GetControlador().subtemas.Where(x => x.IdActa == acta.Id).ToList();

        }

        public void CrearSubtema(Subtema subtema) {

            Crud.Insertar(subtema);

        }

        public void EditarSubtema(Subtema subtema) {

            Crud.Actualizar(subtema);

        }

        public void EliminarSubtema(Subtema subtema) {

            Crud.Eliminar(subtema);

        }

        //Asistencias

        public List<Usuario> GetAsistencias(Acta acta) {

            return Sgsst.GetControlador().asistencias.Where(x => x.IdActa == acta.Id).Join(Sgsst.GetControlador().usuarios,
                asistencia => asistencia.IdUsuario,
                usuario => usuario.Id,
                (asistencia, usuario) => usuario).ToList();

        }

        public void CrearAsistencia(Asistencia asistencia) {

            Crud.Insertar(asistencia);

        }

        public void EditarAsistencia(Asistencia asistencia)
        {

            Crud.Actualizar(asistencia);

        }

        public void EliminarAsistencia(Asistencia asistencia)
        {

            Crud.Eliminar(asistencia);

        }

    }
}
