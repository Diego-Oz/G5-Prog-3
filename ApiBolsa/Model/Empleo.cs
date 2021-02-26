using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ApiBolsa.Model
{
    public partial class Empleo
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Compañia { get; set; }
        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }
        [Required]
        [StringLength(50)]
        public string Posicion { get; set; }
        [Required]
        [StringLength(50)]
        public string Ubicacion { get; set; }
        public int Categorias { get; set; }
        [Required]
        [StringLength(5000)]
        public string Descripcion { get; set; }
        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }
        [Column("URL")]
        [StringLength(100)]
        public string Url { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Column(TypeName = "image")]
        public byte[] Logo { get; set; }

        [ForeignKey(nameof(Categorias))]
        [InverseProperty(nameof(Categoria.Empleos))]
        public virtual Categoria CategoriasNavigation { get; set; }
        public virtual Login EmailNavigation { get; set; }
    }
}
