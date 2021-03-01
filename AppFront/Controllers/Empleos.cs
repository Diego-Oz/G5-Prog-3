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
        private static string url = "https://apibolsa.azurewebsites.net/api/empleos/";
        Empleo emp = new Empleo();
        List<Empleo> lista_emp = new List<Empleo>();

        public async Task<IActionResult> Index()
        {
            List<Empleo> list = new List<Empleo>();
            var htttpcliente = new HttpClient();
            var json = await htttpcliente.GetStringAsync(url);
            list = JsonConvert.DeserializeObject<List<AppFront.Models.Empleo>>(json);
            lista_emp = Enumerable.Reverse(list).ToList();
            return View(lista_emp);
        }
       
        public async Task<IActionResult> IndexPost()
        {
            if (HttpContext.Session.GetString("TipoUsuario") == null)
            {
                return Redirect("../home/login");
            }
            else
            {
                List<Empleo> list = new List<Empleo>();
                var htttpcliente = new HttpClient();
                var json = await htttpcliente.GetStringAsync(url);
                list = JsonConvert.DeserializeObject<List<AppFront.Models.Empleo>>(json);
                lista_emp = Enumerable.Reverse(list).ToList();
                return View(lista_emp);
            }

        }

        

        public async Task<IActionResult> Postular(int categoria)
        {
            if (HttpContext.Session.GetString("TipoUsuario") == null)
            {
                return Redirect("../home/login");
            }
            else
            {
                List<Empleo> list = new List<Empleo>();
                var htttpcliente = new HttpClient();
                var json = await htttpcliente.GetStringAsync(url);
                list = JsonConvert.DeserializeObject<List<AppFront.Models.Empleo>>(json);
                lista_emp = Enumerable.Reverse(list).ToList();
                return View(lista_emp);
            }
        }
        public async Task<IActionResult> Principal()
        {
            List<Empleo> list = new List<Empleo>();
            var htttpcliente = new HttpClient();
            var json = await htttpcliente.GetStringAsync(url);
            list = JsonConvert.DeserializeObject<List<AppFront.Models.Empleo>>(json);
            lista_emp = Enumerable.Reverse(list).ToList();
            return View(lista_emp);
        }

        public async Task<IActionResult> Details(int id)
        {

            emp = new Empleo();
            var accessToken = HttpContext.Session.GetString("JWToken");
            var htttpcliente = new HttpClient();
            htttpcliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var json = await htttpcliente.GetStringAsync(url + id);
            emp = JsonConvert.DeserializeObject<Empleo>(json);
            return View(emp);
        }

        // GET: Empleo/Create

        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("TipoUsuario") == null )
            {
                return Redirect("../home/login");
            }
            else
            {
                return View();
            }

        }
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
        public async Task<IActionResult> Delete(int id)
        {
            if (HttpContext.Session.GetString("TipoUsuario") == "Administrador")
            {
                var accessToken = HttpContext.Session.GetString("JWToken");
                var htttpcliente = new HttpClient();
                htttpcliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                var json = await htttpcliente.GetStringAsync(url + id);
                emp = JsonConvert.DeserializeObject<Empleo>(json);
                return View(emp);
            }
            else if (HttpContext.Session.GetString("TipoUsuario") == "Poster")
            {
                return Redirect("../Empleos/principal");
            }
            else
            {
                return Redirect("../Empleos/index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, Empleo em)
        {

            var accestoken = HttpContext.Session.GetString("JWToken");
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accestoken);
                using (var response = await httpClient.DeleteAsync(url + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return Redirect("~/Empleos/index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (HttpContext.Session.GetString("TipoUsuario") == "Administrador")
            {
                var accessToken = HttpContext.Session.GetString("JWToken");
                var htttpcliente = new HttpClient();
                htttpcliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                var json = await htttpcliente.GetStringAsync(url + id);
                var categoria = JsonConvert.DeserializeObject<Categoria>(json);
                return View(categoria);
            }
            else if (HttpContext.Session.GetString("TipoUsuario") == "Poster")
            {
                return Redirect("../Empleos/principal");
            }
            else
            {
                return Redirect("../Empleos/index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Empleo em)
        {
            emp = new Empleo();
            var accestoken = HttpContext.Session.GetString("JWToken");
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accestoken);
                StringContent content = new StringContent(JsonConvert.SerializeObject(em), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync(url + id, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    emp = JsonConvert.DeserializeObject<Empleo>(apiResponse);
                }
            }
            return Redirect("~/Empleos/index");
        }
    }
}


