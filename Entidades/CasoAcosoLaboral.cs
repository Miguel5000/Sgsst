using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Serializable]
    [Table("casos_acoso_laboral", Schema = "caso_acoso_laboral")]
    public class CasoAcosoLaboral
    {

        private int? id;
        private int? idCreador;
        private int? idCausa;
        private int? idEstado;
        private int? idEmpresa;
        private DateTime? fecha;
        private string hechos;
        private string sugerencia;
        private string incidente;
        private string compromisos; //JArray
        private string incumplimiento;
        private bool? resolucion;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [Required(ErrorMessage = "El caso de acoso laboral debe tener un creador")]
        [Column("id_creador")]
        public int? IdCreador { get => idCreador; set => idCreador = value; }

        [Required(ErrorMessage = "El caso de acoso laboral debe tener una causa")]
        [Column("id_causa")]
        public int? IdCausa { get => idCausa; set => idCausa = value; }

        [Required(ErrorMessage = "El caso de acoso laboral debe tener un estado")]
        [Column("id_estado")]
        public int? IdEstado { get => idEstado; set => idEstado = value; }

        [Required(ErrorMessage = "El caso de acoso laboral debe pertenecer a una empresa")]
        [Column("id_empresa")]
        public int? IdEmpresa { get => idEmpresa; set => idEmpresa = value; }

        [Required(ErrorMessage = "El caso de acoso laboral debe tener una fecha en la que se hizo el reporte")]
        [Column("fecha")]
        public DateTime? Fecha { get => fecha; set => fecha = value; }

        [Required(ErrorMessage = "El caso de acoso laboral debe tener un registro de los hechos ocurridos")]
        [Column("hechos")]
        public string Hechos { get => hechos; set => hechos = value; }

        [Required(ErrorMessage = "El caso de acoso laboral debe tener una sugerencia de cómo cree el acosado que debe tratarse el tema")]
        [Column("sugerencia")]
        public string Sugerencia { get => sugerencia; set => sugerencia = value; }

        [Column("incidente")]
        public string Incidente { get => incidente; set => incidente = value; }

        [Column("compromisos")]
        public string Compromisos { get => compromisos; set => compromisos = value; }

        [Column("incumplimiento")]
        public string Incumplimiento { get => incumplimiento; set => incumplimiento = value; }

        [Column("resolucion")]
        public bool? Resolucion { get => resolucion; set => resolucion = value; }

    }

}
