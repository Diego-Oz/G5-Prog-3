using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ApiBolsa.Model
{
    [Table("Login")]
    [Index(nameof(Email), Name = "UQ__Login__A9D105349FE2C2BE", IsUnique = true)]
    [Index(nameof(Usuario), Name = "Uni_usuario", IsUnique = true)]
    public partial class Login
    {
        public Login()
        {
            Empleos = new HashSet<Empleo>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(256)]
        public string Contraseña { get; set; }
        [Column("Tipo_usuario")]
        [StringLength(50)]
        public string TipoUsuario { get; set; }
        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        public virtual Role TipoUsuarioNavigation { get; set; }
        public virtual ICollection<Empleo> Empleos { get; set; }
    }
}
