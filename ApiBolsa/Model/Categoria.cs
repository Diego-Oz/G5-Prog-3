using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ApiBolsa.Model
{
    public partial class Categoria
    {
        public Categoria()
        {
            Empleos = new HashSet<Empleo>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("Nombre_categoria")]
        [StringLength(50)]
        public string NombreCategoria { get; set; }

        [InverseProperty(nameof(Empleo.CategoriasNavigation))]
        public virtual ICollection<Empleo> Empleos { get; set; }
    }
}
