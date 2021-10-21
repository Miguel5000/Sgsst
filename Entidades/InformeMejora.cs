using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Serializable]
    [Table("informes_mejora", Schema = "informe_mejora")]
    public class InformeMejora
    {

        private int? id;
        private int? idEmpresa;
        private int? año;
        private string temas; //JArray
        private string medidas;  //JArray

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [ForeignKey("Empresa")]
        [Required(ErrorMessage = "El informe debe pertenecer a une empresa")]
        [Column("id_empresa")]
        public int? IdEmpresa { get => idEmpresa; set => idEmpresa = value; }

        [Required(ErrorMessage = "El informe debe tener un año asociado")]
        [Index(IsUnique = true)]
        [Column("año")]
        public int? Año { get => año; set => año = value; }

        [Required(ErrorMessage = "El informe debe tener los temas hablados en la reunión")]
        [Column("temas")]
        public string Temas { get => temas; set => temas = value; }

        [Required(ErrorMessage = "El informe debe tener las medidas tomadas en la reunión")]
        [Column("medidas")]
        public string Medidas { get => medidas; set => medidas = value; }

        //Llaves foráneas
        public Empresa Empresa { get; set; }

    }

}
