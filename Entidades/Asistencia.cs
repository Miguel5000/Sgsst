using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entidades
{

    [Serializable]
    [Table("asistencias", Schema = "acta")]
    public class Asistencia
    {

        private int? id;
        private int? idActa;
        private int? idUsuario;
        private bool? aprobacion;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [Required(ErrorMessage = "La asistencia debe estar asociada a un acta")]
        [Column("id_acta")]
        public int? IdActa { get => idActa; set => idActa = value; }

        [Required(ErrorMessage = "La asistencia debe estar asociada a un usuario")]
        [Column("id_usuario")]
        public int? IdUsuario { get => idUsuario; set => idUsuario = value; }

        [Required(ErrorMessage = "La asistencia debe indicar si el usuario ya ha aprobado el acta")]
        [Column("aprobacion")]
        public bool? Aprobacion { get => aprobacion; set => aprobacion = value; }

    }

}
