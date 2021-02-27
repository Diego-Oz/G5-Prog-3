using AppFront.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AppFront.Controllers
{
    public class Empleos : Controller
    {
        private static string url = "https://apibolsa.azurewebsites.net/api/empleos";

        public async Task<IActionResult> Index()
        {
            var htttpcliente = new HttpClient();
            var json = await htttpcliente.GetStringAsync(url);
            var convertir = JsonConvert.DeserializeObject<List<AppFront.Models.Empleo>>(json);
            return View(convertir);

        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View();
        }

        // GET: Empleo/Create

        public ViewResult Create() => View();
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Empleo empleo)
        {
            Empleo receivedata = new Empleo();
            var accestoken = HttpContext.Session.GetString("JWToken");
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accestoken);
                StringContent content = new StringContent(JsonConvert.SerializeObject(empleo), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync(url, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedata = JsonConvert.DeserializeObject<Empleo>(apiResponse);
                }
            }
            return Redirect("~/empleos/index");

        }

        //Editar
        public async Task<IActionResult> Editar(int id)
        {
            Empleo empleo = new Empleo();

            using (var httpClient = new HttpClient())
            {
                using (var responde = await httpClient.GetAsync("https://apibolsa.azurewebsites.net/api/empleos/" + id))
                {
                    string apiResponde = await responde.Content.ReadAsStringAsync();
                    empleo = JsonConvert.DeserializeObject<Empleo>(apiResponde);
                }
            }
            return View(empleo);
        }
        [HttpPost]
        public async Task<IActionResult> Editar(Empleo empleo)
        {

            Empleo empleoedit = new Empleo();
            using (var httpClient = new HttpClient())
            {
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(empleo.Compañia.ToString()), "Compañia");
                content.Add(new StringContent(empleo.Tipo.ToString()), "Tipo");
                content.Add(new StringContent(empleo.Posicion.ToString()), "Posicion");
                content.Add(new StringContent(empleo.Ubicacion.ToString()), "Ubicacion");
                content.Add(new StringContent(empleo.Categorias.ToString()), "Categorias");
                content.Add(new StringContent(empleo.Descripcion.ToString()), "Descripcion");
                content.Add(new StringContent(empleo.Fecha.ToString()), "Fecha");
                content.Add(new StringContent(empleo.Url.ToString()), "Url");
                content.Add(new StringContent(empleo.Email.ToString()), "Email");
                content.Add(new StringContent(empleo.Logo.ToString()), "");

                using (var responde = await httpClient.PutAsync("https://apibolsa.azurewebsites.net/api/empleos", content))
                {
                    string apiresponde = await responde.Content.ReadAsStringAsync();
                    ViewBag.Result = "succes";
                    empleoedit = JsonConvert.DeserializeObject<Empleo>(apiresponde);
                }
            }
            return Redirect("~/empleos/index");

        
        }
    }
}


