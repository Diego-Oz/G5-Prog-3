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
    public class AdmiController1 : Controller
    {
        private static string url = "https://apibolsa.azurewebsites.net/api/empleos";
        private static string arl = "https://apibolsa.azurewebsites.net/api/categorias";
        //indexEmpleos
        public async Task <ActionResult> Index()
        {
            var htttpcliente = new HttpClient();
            var json = await htttpcliente.GetStringAsync(url);
            var convertir = JsonConvert.DeserializeObject<List<AppFront.Models.Empleo>>(json);
            return View(convertir);
        }

        //indexcategoria

        public async Task<ActionResult> Indexcate()
        {
            var htttpcliente = new HttpClient();
            var json = await htttpcliente.GetStringAsync(arl);
            var convertir = JsonConvert.DeserializeObject<List<AppFront.Models.Categoria>>(json);
            return View(convertir);
        }


        //Editar Empleo
        public async Task<ActionResult> Edit(int id)
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
        public async Task<IActionResult> Edit(Empleo empleo)
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
                content.Add(new StringContent(empleo.Logo.ToString()), "Logo");

                using (var responde = await httpClient.PutAsync("https://apibolsa.azurewebsites.net/api/empleos", content))
                {
                    string apiresponde = await responde.Content.ReadAsStringAsync();
                    ViewBag.Result = "succes";
                    empleoedit = JsonConvert.DeserializeObject<Empleo>(apiresponde);
                }
            }
            return Redirect("~/empleos/index");
        }

        //Editar Categoria

        public async Task<ActionResult> EditCate(int id)
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
        public async Task<IActionResult> EditCate(Categoria category)
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
            return Redirect("~/Admi/indexcate");
        }

        //Agregar Empleo
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
            return Redirect("~/Admi/indexcate");

        }

        //Agregar Categoria
        public ViewResult CreateCate() => View();
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCate(Categoria categoria)
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
            return Redirect("~/Admi/indexCate");

        }


        //Eliminar Empleo
        [HttpPost]
        public async Task<IActionResult> Delete(int  Empleoid)
        {
           
            using (var httpcliente = new HttpClient())
            {
                using (var responde = await httpcliente.DeleteAsync("https://apibolsa.azurewebsites.net/api/empleos/" + Empleoid))
                {
                    string apiresponde = await responde.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction(nameof(Index));
        }

        //EliminarCategoria
        [HttpPost]
        public async Task<IActionResult> Deletecate(int cateid)
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
