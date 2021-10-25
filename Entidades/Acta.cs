using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Serializable]
    [Table("actas", Schema = "acta")]
    public class Acta
    {

        private int? id;
        private int? idLugar;
        private int? idGrupo;
        private int? idTipo;
        private int? idEmpresa;
        private int? numero;
        private DateTime? fecha;
        private TimeSpan? horaInicio;
        private TimeSpan? horaFin;
        private string capacitacion;
        private string tema;
        private string desarrollo;
        private string conclusion;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [Required(ErrorMessage = "El acta debe tener el lugar de la reunión")]
        [Column("id_lugar")]
        public int? IdLugar { get => idLugar; set => idLugar = value; }

        [Required(ErrorMessage = "El acta debe tener el grupo del SGSST que hizo la reunión")]
        [Column("id_grupo")]
        public int? IdGrupo { get => idGrupo; set => idGrupo = value; }

        [Required(ErrorMessage = "El acta debe ser de cierto tipo")]
        [Column("id_tipo")]
        public int? IdTipo { get => idTipo; set => idTipo = value; }

        [Required(ErrorMessage = "El acta debe pertenecer a una empresa")]
        [Column("id_empresa")]
        public int? IdEmpresa { get => idEmpresa; set => idEmpresa = value; }

        [Required(ErrorMessage = "El acta debe tener un número de acta")]
        [Index(IsUnique = true)]
        [Column("numero")]
        public int? Numero { get => numero; set => numero = value; }

        [Required(ErrorMessage = "El acta debe tener una fecha en la que se creó")]
        [Column("fecha")]
        public DateTime? Fecha { get => fecha; set => fecha = value; }

        [Required(ErrorMessage = "El acta debe tener la hora en la que se inición la reunión")]
        [Column("hora_inicio")]
        public TimeSpan? HoraInicio { get => horaInicio; set => horaInicio = value; }

        [Required(ErrorMessage = "El acta debe tener la hora en la que finalizó la reunión")]
        [Column("hora_fin")]
        public TimeSpan? HoraFin { get => horaFin; set => horaFin = value; }

        [Column("capacitacion")]
        public string Capacitacion { get => capacitacion; set => capacitacion = value; }

        [Required(ErrorMessage = "El acta debe tener el tema que se trató en la reunión")]
        [Column("tema")]
        public string Tema { get => tema; set => tema = value; }

        [Required(ErrorMessage = "El acta debe tener el desarrollo de los temas de la reunión")]
        [Column("desarrollo")]
        public string Desarrollo { get => desarrollo; set => desarrollo = value; }

        [Required(ErrorMessage = "El acta debe tener la conclusión de la reunión")]
        [Column("conclusion")]
        public string Conclusion { get => conclusion; set => conclusion = value; }

    }

}
