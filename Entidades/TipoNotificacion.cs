using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Serializable]
    [Table("tipo_notificacion", Schema = "notificacion")]
    public class TipoNotificacion
    {

        private int? id;
        private string tipo;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [Required(ErrorMessage = "El tipo de notificación debe tener un nombre")]
        [StringLength(200, ErrorMessage = "El nombre no puede superar los 200 caracteres")]
        [Index(IsUnique = true)]
        [Column("tipo")]
        public string Tipo { get => tipo; set => tipo = value; }

    }
}
