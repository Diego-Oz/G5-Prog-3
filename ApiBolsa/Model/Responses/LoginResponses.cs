using ApiBolsa.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBolsa.Model.Responses
{
    public class LoginResponses
    {
        public string Usuario { get; set; }
        public string Token { get; set; }
        public string TipoUsuario { get; set; }
        public string Email { get; set; }

    }
}
