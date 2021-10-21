using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Serializable]
    [Table("tipo_pqrs", Schema = "pqrs")]
    public class TipoPqrs
    {

        private int? id;
        private string nombre;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [Required(ErrorMessage = "El tipo de PQRS debe tener un nombre")]
        [StringLength(50, ErrorMessage = "El nombre no puede superar los 50 caracteres")]
        [Index(IsUnique = true)]
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }

    }

}
