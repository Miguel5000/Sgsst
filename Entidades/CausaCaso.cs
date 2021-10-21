using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Serializable]
    [Table("causas_caso", Schema = "caso_acoso_laboral")]
    public class CausaCaso
    {

        private int? id;
        private string nombre;
        private string informacion;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [Required(ErrorMessage = "La causa debe tener un nombre")]
        [StringLength(50, ErrorMessage = "El nombre no puede superar los 50 caracteres")]
        [Index(IsUnique = true)]
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }

        [Required(ErrorMessage = "La causa debe tener una información")]
        [Index(IsUnique = true)]
        [Column("informacion")]
        public string Informacion { get => informacion; set => informacion = value; }
    
    }

}
