using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Serializable]
    [Table("tipos_acta", Schema = "acta")]
    public class TipoActa
    {

        private int? id;
        private string tipo;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [Required(ErrorMessage = "El tipo de acta debe tener un nombre")]
        [StringLength(50, ErrorMessage = "El tipo de acta no puede superar los 50 caracteres")]
        [Index(IsUnique = true)]
        [Column("tipo")]
        public string Tipo { get => tipo; set => tipo = value; }
    
    }
}
