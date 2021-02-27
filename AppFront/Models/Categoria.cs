using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppFront.Models
{
    public class Categoria
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }
        [Required]
        [Column("Nombre_categoria")]
        [StringLength(50)]
        public string NombreCategoria { get; set; }
    }
}
