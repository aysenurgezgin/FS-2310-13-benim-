using Microsoft.AspNetCore.Mvc;
using MvcFileUploadApp.Models;
using System.Diagnostics;

namespace MvcFileUploadApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult UpLoadImage(IFormFile image) 
        {
            if (image == null) 
            {
                ViewBag.Message = "Resimde bir sorun var,tekrar dene";
                return View("Index");
            }
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", image.FileName);
            using (var stream= new FileStream(path,FileMode.Create))
            {
                image.CopyTo(stream);
            }


            ViewBag.Message = "Resim başarıyla yüklendi.";
            return View("Index");
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ResimYukle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ResimYukle(IFormFile image)
        {

            //Buraya resim yükleme için hazırayacağımız methotu çağıracağız.
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}