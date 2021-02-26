using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ApiBolsa.Model
{
    [Index(nameof(Rol), Name = "UQ__Roles__CAF00514D7179A9E", IsUnique = true)]
    public partial class Role
    {
        public Role()
        {
            Logins = new HashSet<Login>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Rol { get; set; }

        public virtual ICollection<Login> Logins { get; set; }
    }
}
