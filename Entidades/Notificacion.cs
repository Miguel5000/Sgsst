using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Serializable]
    [Table("notificaciones", Schema = "notificacion")]
    public class Notificacion
    {

        private int? id;
        private int? idTipoNotificacion;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [Required(ErrorMessage = "La notificación debe ser de cierto tipo")]
        [Column("id_tipo_notificacion")]
        public int? IdTipoNotificacion { get => idTipoNotificacion; set => idTipoNotificacion = value; }

    }
}
