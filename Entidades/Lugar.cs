using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Serializable]
    [Table("lugares", Schema = "lugar")]
    public class Lugar
    {

        private int? id;
        private int? idEmpresa;
        private string nombre;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [ForeignKey("Empresa")]
        [Required(ErrorMessage = "El lugar debe estar asociado a una empresa")]
        [Column("id_empresa")]
        public int? IdEmpresa { get => idEmpresa; set => idEmpresa = value; }

        [Required(ErrorMessage = "El lugar debe tener un nombre")]
        [StringLength(50, ErrorMessage = "El nombre no puede superar los 50 caracteres")]
        [Index(IsUnique = true)]
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }

        //Llaves foráneas
        public Empresa Empresa { get; set; }
    }
}
