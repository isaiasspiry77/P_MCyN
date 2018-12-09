using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MCN.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace MCN.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {

            //return RedirectToAction("Logaout", "Account");

            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            
            if (HttpContext.Session.GetInt32("tipo") == 0)
                return RedirectToAction("Logaout", "Account");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int id = (int) HttpContext.Session.GetInt32("id") ;
            if (correo == null || pass == null || tipo == 0 || id == 0)
                return RedirectToAction("Logaout", "Account");

            if (tipo == 1)
            {
                ViewData["id"] = id;
                ViewData["correo"] = correo;
                ViewData["tipo"] = tipo;

                return View();
            }
            else
            {
                ViewData["id"] = id;
                ViewData["correo"] = correo;
                ViewData["tipo"] = tipo;

                return View();
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
