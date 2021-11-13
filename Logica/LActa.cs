﻿using Datos;
using Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class LActa
    {

        private Sgsst controlador = new Sgsst();

        public List<Acta> GetActas(GrupoSgsst grupo, TipoActa tipoActa, Empresa empresa, bool? publicacion) {

            return this.controlador.actas.Where(x => x.IdGrupo == grupo.Id && 
            x.IdTipo == tipoActa.Id && 
            x.IdEmpresa == empresa.Id &&
            x.Publicacion == publicacion).ToList();

        }

        public Acta Get(int id) {

            return this.controlador.actas.Where(x => x.Id == id).FirstOrDefault();

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

            return this.controlador.tiposActa.Where(x => x.Id == id).FirstOrDefault();

        }

        //Subtemas

        public List<Subtema> GetSubtemas(Acta acta) {

            return this.controlador.subtemas.Where(x => x.IdActa == acta.Id).ToList();

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

            return this.controlador.asistencias.Where(x => x.IdActa == acta.Id).Join(this.controlador.usuarios,
                asistencia => asistencia.IdUsuario,
                usuario => usuario.Id,
                (asistencia, usuario) => usuario).ToList();

        }

        public List<Asistencia> GetVerdaderasAsistencias(Acta acta)
        {

            return this.controlador.asistencias.Where(x => x.IdActa == acta.Id).ToList();

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
