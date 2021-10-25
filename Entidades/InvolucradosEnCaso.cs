using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Serializable]
    [Table("involucrados_en_caso", Schema = "caso_acoso_laboral")]
    public class InvolucradosEnCaso
    {

        private int? id;
        private int? idUsuario;
        private int? idReporte;
        private string version;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [Required(ErrorMessage = "Debe haber un usuario involucrado")]
        [Column("id_usuario")]
        public int? IdUsuario { get => idUsuario; set => idUsuario = value; }

        [Required(ErrorMessage = "Debe haber un reporte vinculado al usuario involucrado")]
        [Column("id_reporte")]
        public int? IdReporte { get => idReporte; set => idReporte = value; }

        [Column("version")]
        public string Version { get => version; set => version = value; }

    }

}
