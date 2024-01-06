using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proje06_MVCWithSql.Dal;
using Proje06_MVCWithSql.Models;

namespace Proje06_MVCWithSql.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        
            


        Db.OpenCn();

        return View();
    }

}
