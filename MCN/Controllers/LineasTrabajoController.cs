using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCN.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCN.Controllers
{
    public class LineasTrabajoController : Controller
    {
        [HttpGet]
        public ActionResult AgregarLineaTrabajo(string nombre)
        {
            var n = nombre;
            var tc = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            CatLineaTrabajo linet = new CatLineaTrabajo();
            linet.LineasTrabajo = n;
            linet.Status = 1;

            tc.CatLineaTrabajo.Add(linet);
            tc.SaveChanges();
            return RedirectToAction("Listado", "SuperUsuarios");
        }
    }
}