using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppGerdes.Models;

namespace FirstResponsiveWebAppGerdes.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.YOB = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(AgeFinder model) 
        {
            ViewBag.YOB = model.AgeThisYear();
            return View(model);
        }
    }
}
