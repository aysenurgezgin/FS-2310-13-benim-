using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Proje06_MVCWithSql.Controllers
{
  
    public class ProductController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        
    }
}