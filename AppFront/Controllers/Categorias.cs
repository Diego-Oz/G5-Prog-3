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

        private static string url = "https://apibolsa.azurewebsites.net/api/Categorias";
        // GET: AdmiController1
        public async Task<ActionResult> Index()
        {
            var accessToken = HttpContext.Session.GetString("JWToken");
            var htttpcliente = new HttpClient();
            htttpcliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var json = await htttpcliente.GetStringAsync(url);
            var lista_categorias= JsonConvert.DeserializeObject<List<AppFront.Models.Categoria>>(json);
            return View(lista_categorias);
        }

        // GET: AdmiController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: AdmiController1/Edit/5

        public async Task<ActionResult> Edit(int id)
        {
            Categoria categori = new Categoria();

            using (var httpClient = new HttpClient())
            {
                using (var responde = await httpClient.GetAsync("https://apibolsa.azurewebsites.net/api/Categorias/" + id))
                {
                    string apiResponde = await responde.Content.ReadAsStringAsync();
                    categori = JsonConvert.DeserializeObject<Categoria>(apiResponde);
                }
            }
            return View(categori);


        }

       
        [HttpPost]
        public async Task<IActionResult> Edit( Categoria category)
        {
            Categoria categori = new Categoria();
            using (var httpClient = new HttpClient())
            {
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(category.ID.ToString()), "Id");
                content.Add(new StringContent(category.NombreCategoria.ToString()), "NombreCategoria");

                using (var responde = await httpClient.PutAsync("https://apibolsa.azurewebsites.net/api/Categorias", content))
                {
                    string apiresponde = await responde.Content.ReadAsStringAsync();
                    ViewBag.Result = "succes";
                    categori = JsonConvert.DeserializeObject<Categoria>(apiresponde);
                }
            }
            return Redirect("~/empleos/index");
        }

        //Agregar 
        public ViewResult Create() => View();
        [HttpPost]
        public async Task<IActionResult> Create(Categoria nuevo)
        {
            var accestoken = HttpContext.Session.GetString("JWToken");
            Categoria receivedata = new Categoria();
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accestoken);
                StringContent content = new StringContent(JsonConvert.SerializeObject(nuevo), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://apibolsa.azurewebsites.net/api/Categorias", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedata = JsonConvert.DeserializeObject<Categoria>(apiResponse);
                }
            }
            return Redirect("~/categorias/index");

        }



        [HttpPost]
        public async Task<IActionResult> Delete(int cateid)
        {
            using (var httpcliente = new HttpClient())
            {
                var accessToken = HttpContext.Session.GetString("JWToken");
                httpcliente.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                using (var responde = await httpcliente.DeleteAsync("https://apibolsa.azurewebsites.net/api/Categorias/" + cateid))
                {
                    string apiresponde = await responde.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction(nameof(Index));

        }



      
    }
}
