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
    public class Categorias : Controller
    {
        Categoria cate = new Categoria();
        List<Categoria> lista_cate = new List<Categoria>();

        private static string url = "https://apibolsa.azurewebsites.net/api/Categorias/";
        public async Task<ActionResult> Index()
        {
            lista_cate = new List<Categoria>();
            var accessToken = HttpContext.Session.GetString("JWToken");
            var htttpcliente = new HttpClient();
            htttpcliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var json = await htttpcliente.GetStringAsync(url);
            lista_cate = JsonConvert.DeserializeObject<List<Categoria>>(json);
            return View(lista_cate);
        }


        public async Task<ActionResult> Details(int id)
        {
            cate = new Categoria();
            var accessToken = HttpContext.Session.GetString("JWToken");
            var htttpcliente = new HttpClient();
            htttpcliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var json = await htttpcliente.GetStringAsync(url + id);
            cate = JsonConvert.DeserializeObject<Categoria>(json);
            return View(cate);
        }

        public ViewResult Create() => View();
        [HttpPost]
        public async Task<IActionResult> Create(Categoria nuevo)
        {
            var accestoken = HttpContext.Session.GetString("JWToken");
            cate = new Categoria();
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accestoken);
                StringContent content = new StringContent(JsonConvert.SerializeObject(nuevo), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://apibolsa.azurewebsites.net/api/Categorias", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cate = JsonConvert.DeserializeObject<Categoria>(apiResponse);
                }
            }
            return Redirect("~/categorias/index");

        }

        public async Task<IActionResult> Delete(int id)
        {
            var accessToken = HttpContext.Session.GetString("JWToken");
            var htttpcliente = new HttpClient();
            htttpcliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var json = await htttpcliente.GetStringAsync(url + id);
            cate = JsonConvert.DeserializeObject<Categoria>(json);
            return View(cate);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, Categoria cate)
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
            return Redirect("~/categorias/index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var accessToken = HttpContext.Session.GetString("JWToken");
            var htttpcliente = new HttpClient();
            htttpcliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var json = await htttpcliente.GetStringAsync(url + id);
            var categoria = JsonConvert.DeserializeObject<Categoria>(json);
            return View(categoria);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Categoria ca)
        {
            cate = new Categoria();
            var accestoken = HttpContext.Session.GetString("JWToken");
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accestoken);
                StringContent content = new StringContent(JsonConvert.SerializeObject(ca), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync(url+id, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cate = JsonConvert.DeserializeObject<Categoria>(apiResponse);
                }
            }
            return Redirect("~/categorias/index");
        }


    }
}
