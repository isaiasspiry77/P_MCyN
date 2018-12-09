using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCN.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCN.Controllers
{
    public class DependenciasController : Controller
    {
        [HttpGet]
        public ActionResult AgregarDependencia(string nombre, int id_insti)
        {
            var n = nombre;
            var id = id_insti;

            var tc = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            CatExtenciones depen = new CatExtenciones();
            depen.NombreExtencion = n;
            depen.RInstituciones = id;
            depen.Status = 1;

            tc.CatExtenciones.Add(depen);
            tc.SaveChanges();

            return RedirectToAction("Listado", "SuperUsuarios");
        }
    }
}