using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Serializable]
    [Table("areas", Schema = "area")]
    public class Area
    {

        private int? id;
        private int? idEmpresa;
        private string nombre;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [ForeignKey("Empresa")]
        [Required(ErrorMessage = "El área debe pertenecer a una empresa")]
        [Column("id_empresa")]
        public int? IdEmpresa { get => idEmpresa; set => idEmpresa = value; }

        [Required(ErrorMessage = "El área debe tener un nombre")]
        [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres")]
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }

        //Llaves foráneas
        public Empresa Empresa { get; set; }
    }
}
