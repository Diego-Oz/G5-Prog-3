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

        Empleo emp = new Empleo();
        List<Empleo> List_emp = new List<Empleo>();

        private static string url = "https://apibolsa.azurewebsites.net/api/empleos/";

        public async Task<IActionResult> Index()
        {
            List_emp = new List<Empleo>();
            var htttpcliente = new HttpClient();
            var json = await htttpcliente.GetStringAsync(url);
            List_emp = JsonConvert.DeserializeObject<List<Empleo>>(json);
            return View(List_emp);
        }

        public async Task<ActionResult> Details(int id)
        {
            emp = new Empleo();
            var htttpcliente = new HttpClient();
            var json = await htttpcliente.GetStringAsync(url + id);
            emp = JsonConvert.DeserializeObject<Empleo>(json);
            return View(emp);
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

        public async Task<IActionResult> Delete(int id)
        {
            var accessToken = HttpContext.Session.GetString("JWToken");
            var htttpcliente = new HttpClient();
            htttpcliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var json = await htttpcliente.GetStringAsync(url + id);
            emp = JsonConvert.DeserializeObject<Empleo>(json);
            return View(emp);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, Empleo emp)
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
            var accessToken = HttpContext.Session.GetString("JWToken");
            var htttpcliente = new HttpClient();
            htttpcliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var json = await htttpcliente.GetStringAsync(url + id);
            emp = JsonConvert.DeserializeObject<Empleo>(json);
            return View(emp);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Empleo editar)
        {
            emp = new Empleo();
            var accestoken = HttpContext.Session.GetString("JWToken");
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accestoken);
                StringContent content = new StringContent(JsonConvert.SerializeObject(editar), Encoding.UTF8, "application/json");

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


