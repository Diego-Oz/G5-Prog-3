using ApiBolsa.Model;
using ApiBolsa.Model.Common;
using ApiBolsa.Model.Request;
using ApiBolsa.Model.Responses;
using ApiBolsa.Tools;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApiBolsa.Servicios
{
    public class LoginService : ILoginService
    {
        private readonly AppSetting _appSettings;

        public LoginService(IOptions<AppSetting> appsettings)
        {
            _appSettings = appsettings.Value;
        }

        public LoginResponses Auth(LoginRequest model)
        {
            LoginResponses loginresponses = new LoginResponses();
            using (var db = new BolsaContext())
            {
                string spass = Encryptar.GetSHA256(model.Password);
                var user = db.Logins.Where(x => x.Usuario == model.Usuario && 
                                                x.Contraseña == spass).FirstOrDefault();
                if (user == null)
                {
                    return null;
                }
                else
                {
                    loginresponses.Usuario = user.Usuario;
                    loginresponses.Token = GetToken(user);
                    loginresponses.TipoUsuario = user.TipoUsuario;
                    loginresponses.Email = user.Email;
                }
            }
            return loginresponses;
        }

        private string GetToken(Login Model)
        {
            var tokenhandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(_appSettings.Secreto);
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, Model.Id.ToString()),
                    new Claim(ClaimTypes.Name, Model.Usuario),
                    new Claim(ClaimTypes.Email, Model.Email),
                    new Claim(ClaimTypes.Role, Model.TipoUsuario)

                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),
                SecurityAlgorithms.HmacSha256Signature)

            };
            var token = tokenhandler.CreateToken(tokenDescriptor);
            return tokenhandler.WriteToken(token);
        }

    }
}
