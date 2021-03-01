using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppFront.Models
{
    public class Login
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(256)]
        public string Contraseña { get; set; }
        [Column("Tipo_usuario")]
        [StringLength(50)]
        public string TipoUsuario { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50)]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(100)]
        public string Email { get; set; }

        public virtual ICollection<Empleo> Empleos { get; set; }
    }
}
