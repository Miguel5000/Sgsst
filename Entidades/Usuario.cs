using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{

    [Serializable]
    [Table("usuarios", Schema="usuario")]
    public class Usuario
    {

        private int? id;
        private int? idRol;
        private int? idArea;
        private int? idEmpresa;
        private string nombre;
        private string correo;
        private string celular;
        private string clave;
        private string tokenRecuperarClave;

        [Key]
        [Column("id")]
        public int? Id { get => id; set => id = value; }

        [Required(ErrorMessage = "El usuario debe tener un rol")]
        [Column("id_rol")]
        public int? IdRol { get => idRol; set => idRol = value; }

        [Required(ErrorMessage = "El usuario debe pertenecer a un área")]
        [Column("id_area")]
        public int? IdArea { get => idArea; set => idArea = value; }

        [Required(ErrorMessage = "El usuario debe pertenecer a una empresa")]
        [Column("id_empresa")]
        public int? IdEmpresa { get => idEmpresa; set => idEmpresa = value; }

        [Required(ErrorMessage = "El usuario debe tener un nombre")]
        [StringLength(50, ErrorMessage = "El nombre no puede superar los 50 caracteres")]
        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }

        [Required(ErrorMessage = "El usuario debe tener un correo")]
        [StringLength(50, ErrorMessage = "El correo no puede superar los 50 caracteres")]
        [Index(IsUnique = true)]
        [Column("correo")]
        public string Correo { get => correo; set => correo = value; }

        [Required(ErrorMessage = "El usuario debe tener un celular")]
        [StringLength(15, ErrorMessage = "El celular no puede superar los 15 caracteres")]
        [Index(IsUnique = true)]
        [Column("celular")]
        public string Celular { get => celular; set => celular = value; }

        [Required(ErrorMessage = "El usuario debe tener una clave")]
        [StringLength(50, ErrorMessage = "La clave no puede superar los 50 caracteres")]
        [Column("clave")]
        public string Clave { get => clave; set => clave = value; }

        [StringLength(200, ErrorMessage = "El token no puede superar los 200 caracteres")]
        [Column("token_recuperar_clave")]
        public string TokenRecuperarClave { get => tokenRecuperarClave; set => tokenRecuperarClave = value; }

    }
}
