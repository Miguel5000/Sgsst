using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Serializable]
    [Table("tipo_brigada", Schema = "empresa")]
    public class TipoBrigada
    {

        private int? id;
        private string clase;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [Required(ErrorMessage = "El tipo de brigada debe tener una clase")]
        [StringLength(3, ErrorMessage = "La clase no puede superar los 3 caracteres")]
        [Index(IsUnique = true)]
        [Column("clase")]
        public string Clase { get => clase; set => clase = value; }
    }
}
