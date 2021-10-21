using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Serializable]
    [Table("subtemas", Schema = "acta")]
    public class Subtema
    {

        private int? id;
        private int? idGrupo;
        private int? idActa;
        private string subtemaActa;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [ForeignKey("GrupoSgsst")]
        [Column("id_grupo")]
        public int? IdGrupo { get => idGrupo; set => idGrupo = value; }

        [ForeignKey("Acta")]
        [Required(ErrorMessage = "El subtema debe pertenecer a un acta")]
        [Column("id_acta")]
        public int? IdActa { get => idActa; set => idActa = value; }

        [Required(ErrorMessage = "El subtema debe tener un contenido")]
        [Column("subtema")]
        public string SubtemaActa { get => subtemaActa; set => subtemaActa = value; }

        //Llaves foráneas
        public GrupoSgsst GrupoSgsst { get; set; }
        public Acta Acta { get; set; }

    }
}
