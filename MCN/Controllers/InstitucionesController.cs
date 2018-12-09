using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCN.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCN.Controllers
{
    public class InstitucionesController : Controller
    {
        [HttpGet]
        public JsonResult LoadData()
        {
            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var list = (from datos in context.CatInstituciones
                        where datos.Status == 1
                        select new
                        {
                            id = datos.IdInstituto,
                            nombre = datos.NombreInstituto
                        }).ToList();
            var cadena = "";
            foreach (var x in list)
            {
                cadena = cadena + "<option value='" + x.id + "'>" + x.nombre + "</option>";
            };

            return Json(cadena);
        }

        // GET: Instituciones/Create
        [HttpGet]
        public ActionResult AgregarInstitucion(string nombre)
        {
            var n = nombre;
            var tc = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            CatInstituciones insti = new CatInstituciones();
            insti.NombreInstituto = n;
            insti.Status = 1;

            tc.CatInstituciones.Add(insti);
            tc.SaveChanges();

            return RedirectToAction("RegistrarPersonal", "Personal");
        }
    }
}