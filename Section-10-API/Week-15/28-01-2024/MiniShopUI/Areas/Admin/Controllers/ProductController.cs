using Microsoft.AspNetCore.Mvc;
using MiniShop.MVC.Areas.Admin.Models;
using MiniShop.MVC.Helpers;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace MiniShop.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        public async Task<IActionResult> Index()
        {
            Response<List<ProductViewModel>> response = new Response<List<ProductViewModel>>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync("http://localhost:7700/Products");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<List<ProductViewModel>>>(contentResponseApi);
            }
            
            return View(response.Data);
        }
        public async Task<IActionResult> UpdateIsHome(int id)
        {
            HttpClient httpClient = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri= new Uri($"http://localhost:7700/Products/UpdateIsHome/{id}"),
                Content=new StringContent("",Encoding.UTF8,"application/json")
            };
            HttpResponseMessage response = await httpClient.SendAsync(request);

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            HttpClient httpClient = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"http://localhost:7700/Products/UpdateIsActive/{id}"),
                Content = new StringContent("", Encoding.UTF8, "application/json")
            };
            HttpResponseMessage response = await httpClient.SendAsync(request);

            return RedirectToAction("Index");
        }

        [NonAction]
        public async Task<List<CategoryViewModel>> GetCategories()

        {
            Response<List<CategoryViewModel>> response = new Response<List<CategoryViewModel>>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync("http://localhost:7700/Categories");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<List<CategoryViewModel>>>(contentResponseApi);
            }
            return response.Data;
        }
            [HttpGet]
        public async Task<IActionResult> Create()
        {
            AddProductViewModel model = new AddProductViewModel
            {
                Categories = await GetCategories()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddProductViewModel model)
        {
            model.Properties = "Geçici olarak otomatik metin üretiliyor";
            model.Url = Jobs.GetUrl(model.Name);
            if(ModelState.IsValid) 
            {
                if (model.CategoryIds !=null)

                {
                    using (var httpClient = new HttpClient())
                    {
                        var serializeModel = JsonSerializer.Serialize(model);
                        StringContent stringContent = new StringContent(serializeModel, Encoding.UTF8, "application/json");
                        var result = await httpClient.PostAsync("http://localhost:7700/Products/Create", stringContent);
                        if (result.IsSuccessStatusCode)
                        {
                            return RedirectToAction("Index");
                        }
                    }
                }


                ViewBag.CategoryErrorMessage = "Herhangi bir kategori seçmeden,ürün kaydı yapılamaz.";

            }
            model.Categories=await GetCategories();
            return View(model);
            
        }
    }
}

