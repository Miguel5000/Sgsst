using Entidades;
using System.Data.Entity;

namespace Datos
{
    public class Sgsst : DbContext
    {

        public Sgsst() : base("name=Sgsst")
        {

        }

       
        public DbSet<Acta> actas { get; set; }
        public DbSet<Area> areas { get; set; }
        public DbSet<Asistencia> asistencias { get; set; }
        public DbSet<CasoAcosoLaboral> casos { get; set; }
        public DbSet<CausaCaso> causas { get; set; }
        public DbSet<Empresa> empresas { get; set; }
        public DbSet<EstadoCaso> estadosCaso { get; set; }
        public DbSet<GrupoSgsst> grupos { get; set; }
        public DbSet<InformeMejora> informes { get; set; }
        public DbSet<InvolucradosEnCaso> involucraciones { get; set; }
        public DbSet<Lugar> lugares { get; set; }
        public DbSet<Notificacion> notificaciones { get; set; }
        public DbSet<NotificacionesDeUsuario> notificacionesDeUsuarios { get; set; }
        public DbSet<Pqrs> pqrs { get; set; }
        public DbSet<Rol> roles { get; set; }
        public DbSet<Subtema> subtemas { get; set; }
        public DbSet<TipoActa> tiposActa { get; set; }
        public DbSet<TipoBrigada> tiposBrigada { get; set; }
        public DbSet<TipoNotificacion> tiposNotificacion { get; set; }
        public DbSet<TipoPqrs> tiposPqrs { get; set; }
        public DbSet<Usuario> usuarios { get; set; }

    }
}
