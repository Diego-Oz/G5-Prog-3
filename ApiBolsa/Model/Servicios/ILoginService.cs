using ApiBolsa.Model;
using ApiBolsa.Model.Request;
using ApiBolsa.Model.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBolsa.Servicios
{
    public interface ILoginService
    {
        LoginResponses Auth(LoginRequest model);
    }
}
