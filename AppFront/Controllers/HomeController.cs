using AppFront.Models;
using AppFront.Models.Request;
using AppFront.Models.Respuestas;
using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using IdentityModel;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;

namespace AppFront.Controllers
{
    public class HomeController : Controller
    {
        

        public async Task<IActionResult> Index()
        {
            var accessToken = HttpContext.Session.GetString("JWToken");
            var htttpcliente = new HttpClient();
            htttpcliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var json = await htttpcliente.GetStringAsync("https://apibolsa.azurewebsites.net/api/logins");
            var Lista_Usuarios = JsonConvert.DeserializeObject<List<Login>>(json);
            return View(Lista_Usuarios);    
        }

        public ViewResult Crear() => View();
        [HttpPost]
        public async Task<IActionResult> Crear(Login nuevo)
        {
            LoginResponse receivedata = new LoginResponse();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(nuevo), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://apibolsa.azurewebsites.net/api/Logins", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedata = JsonConvert.DeserializeObject<LoginResponse>(apiResponse);
                }
            }
            return Redirect("~/Home/Login");
        }



        public ViewResult Login() => View();
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest login)
        {
            LoginResponse receivedata = new LoginResponse();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://apibolsa.azurewebsites.net/api/Logins/login", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedata = JsonConvert.DeserializeObject<LoginResponse>(apiResponse);
                    HttpContext.Session.SetString("JWToken", receivedata.Token);
                    HttpContext.Session.SetString("TipoUsuario", receivedata.TipoUsuario);
                    HttpContext.Session.SetString("Email", receivedata.Email);

                }
            }
            return Redirect("~/Empleos/Principal");
        }

       

    }
}
