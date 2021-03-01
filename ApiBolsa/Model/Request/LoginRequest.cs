using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBolsa.Model.Request
{
    public class LoginRequest
    {
        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
