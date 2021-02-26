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

        private static string url = "https://apibolsa.azurewebsites.net/api/categorias";
        // GET: AdmiController1
        public async Task<ActionResult> Index()
        {
            var htttpcliente = new HttpClient();
            var json = await htttpcliente.GetStringAsync(url);
            var lista_categorias= JsonConvert.DeserializeObject<List<Empleos>>(json);
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
                using (var responde = await httpClient.GetAsync("https://apibolsa.azurewebsites.net/api/categorias/" + id))
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
                content.Add(new StringContent(category.Id.ToString()), "Id");
                content.Add(new StringContent(category.NombreCategoria.ToString()), "NombreCategoria");

                using (var responde = await httpClient.PutAsync("https://apibolsa.azurewebsites.net/api/categorias", content))
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Categoria categoria)
        {
            Categoria receivedata = new Categoria();
            var accestoken = HttpContext.Session.GetString("JWToken");
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accestoken);
                StringContent content = new StringContent(JsonConvert.SerializeObject(categoria), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync(url, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedata = JsonConvert.DeserializeObject<Categoria>(apiResponse);
                }
            }
            return Redirect("~/Categorias/index");

        }



        [HttpPost]
        public async Task<IActionResult> Delete(int cateid)
        {
            using (var httpcliente = new HttpClient())
            {
                using (var responde = await httpcliente.DeleteAsync("https://apibolsa.azurewebsites.net/api/categorias/" + cateid))
                {
                    string apiresponde = await responde.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction(nameof(Index));

        }



      
    }
}
