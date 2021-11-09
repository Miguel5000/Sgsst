using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entidades
{

    [Serializable]
    [Table("empresas", Schema = "empresa")]
    public class Empresa
    {

        private int? id;
        private int? idTipoBrigada;
        private string nombre;
        private string logotipo;
        private string logotipoFront;
        private int? dimensionArea;
        private string direccion;
        private string telefono;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [Column("id_tipo_brigada")]
        public int? IdTipoBrigada { get => idTipoBrigada; set => idTipoBrigada = value; }

        [Required(ErrorMessage = "La empresa debe tener un nombre")]
        [StringLength(20, ErrorMessage = "El nombre no puede superar los 20 caracteres")]
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }

        [StringLength(200, ErrorMessage = "El enlace del logotipo no puede superar los 200 caracteres")]
        [Column("logotipo")]
        public string Logotipo { get => logotipo; set => logotipo = value; }

        [NotMapped]
        public string LogotipoFront { get => logotipoFront; set => logotipoFront = value; }

        [Required(ErrorMessage = "La empresa debe tener una dimensión")]
        [Column("dimension_area")]
        public int? DimensionArea { get => dimensionArea; set => dimensionArea = value; }

        [Required(ErrorMessage = "La empresa debe tener una dirección")]
        [StringLength(100, ErrorMessage = "La dirección no puede superar los 100 caracteres")]
        [Column("direccion")]
        public string Direccion { get => direccion; set => direccion = value; }

        [Required(ErrorMessage = "La empresa debe tener un número de teléfono")]
        [StringLength(15, ErrorMessage = "El número de teléfono no puede superar los 15 caracteres")]
        [Column("telefono")]
        public string Telefono { get => telefono; set => telefono = value; }

    }
}
