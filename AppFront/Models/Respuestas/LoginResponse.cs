    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFront.Models.Respuestas
{
    public class LoginResponse
    {
        public string Usuario { get; set; }
        public string Token { get; set; }
        public string TipoUsuario { get; set; }
        public string Email { get; set; }

    }
}
