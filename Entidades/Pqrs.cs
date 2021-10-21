using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Serializable]
    [Table("pqrs", Schema = "pqrs")]
    public class Pqrs
    {

        private int? id;
        private int? idTipo;
        private int? idEmpresa;
        private int? idUsuario;
        private int? idGrupo;
        private string titulo;
        private DateTime? fecha;
        private string contenido;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [ForeignKey("TipoPqrs")]
        [Required(ErrorMessage = "El PQRS debe tener un tipo")]
        [Column("id_tipo")]
        public int? IdTipo { get => idTipo; set => idTipo = value; }

        [ForeignKey("Empresa")]
        [Required(ErrorMessage = "El PQRS debe pertenecer a una empresa")]
        [Column("id_empresa")]
        public int? IdEmpresa { get => idEmpresa; set => idEmpresa = value; }

        [ForeignKey("Usuario")]
        [Required(ErrorMessage = "El PQRS debe estar asociado al usuario que lo envió")]
        [Column("id_usuario")]
        public int? IdUsuario { get => idUsuario; set => idUsuario = value; }

        [ForeignKey("GrupoSgsst")]
        [Required(ErrorMessage = "El PQRS debe estar asociado al grupo que lo recibe")]
        [Column("id_grupo")]
        public int? IdGrupo { get => idGrupo; set => idGrupo = value; }

        [Required(ErrorMessage = "El PQRS debe tener un título")]
        [StringLength(50, ErrorMessage = "El título no puede superar los 50 caracteres")]
        [Column("titulo")]
        public string Titulo { get => titulo; set => titulo = value; }

        [Required(ErrorMessage = "El PQRS debe tener una fecha de envío")]
        [Column("fecha")]
        public DateTime? Fecha { get => fecha; set => fecha = value; }

        [Required(ErrorMessage = "El PQRS debe tener un contenido")]
        [Column("contenido")]
        public string Contenido { get => contenido; set => contenido = value; }

        //Llaves foráneas
        public TipoPqrs TipoPqrs { get; set; }
        public Empresa Empresa { get; set; }
        public Usuario Usuario { get; set; }
        public GrupoSgsst GrupoSgsst { get; set; }
    }

}
