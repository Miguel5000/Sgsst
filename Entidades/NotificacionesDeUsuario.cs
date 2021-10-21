using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Serializable]
    [Table("notificaciones_de_usuario", Schema = "notificacion")]
    public class NotificacionesDeUsuario
    {

        private int? id;
        private int? idUsuario;
        private int? idNotificacion;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [ForeignKey("Usuario")]
        [Required(ErrorMessage = "La notificación debe estar asociada al usuario que la ve")]
        [Column("id_usuario")]
        public int? IdUsuario { get => idUsuario; set => idUsuario = value; }

        [ForeignKey("Notificacion")]
        [Required(ErrorMessage = "La notificación del usuario debe tener una notificación como base")]
        [Column("id_notificacion")]
        public int? IdNotificacion { get => idNotificacion; set => idNotificacion = value; }

        //Llaves foráneas
        public Usuario Usuario { get; set; }
        public Notificacion Notificacion { get; set; }

    }
}
