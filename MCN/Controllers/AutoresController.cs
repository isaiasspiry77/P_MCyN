using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCN.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCN.Controllers
{
    public class AutoresController : Controller
    {
        public ActionResult Listado()
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int id = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var Autores = context.Autores.Where(pe => pe.TipoA == 1 && pe.Status == 1);

            ViewData["id"] = id;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View(Autores);
        }

        // GET: Autores/Details/5
        public ActionResult Perfil()
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int id = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;

            Autores InfoAutor = context.Autores.Where(pa => pa.IdAutores == id && pa.Status != 2).First();

            InfoAutor.TipoANavigation = context.TipoPersonal.Where(t => t.IdTipoP == InfoAutor.TipoA).First();
            InfoAutor.StatusNavigation = context.Estados.Where(es => es.IdEstado == InfoAutor.Status).First();

            ViewData["id"] = id;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View(InfoAutor);
        }

        // GET: Autores/Edit/5
        public ActionResult Configuracion()
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int id = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;

            Autores InfoAutor = context.Autores.Where(pa => pa.IdAutores == id && pa.Status != 2).First();

            ViewData["id"] = id;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View(InfoAutor);
        }

        // POST: Autores/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Configuracion(Autores autor)
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int id = (int)HttpContext.Session.GetInt32("id");
            try
            {
                // TODO: Add update logic here
                var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
                var autorInfo = context.Autores.Find(new object[] { id });

                autorInfo.NombreA = autor.NombreA;
                autorInfo.ApellidosA = autor.ApellidosA;
                autorInfo.NombreUsuarioA = autor.NombreUsuarioA;
                autorInfo.CorreoElectronicoA = autor.CorreoElectronicoA;

                if (autor.ContraseniaA != null)
                    autorInfo.ContraseniaA = autor.ContraseniaA;

                context.Update(autorInfo);
                context.SaveChanges();

                ViewData["id"] = id;
                ViewData["correo"] = correo;
                ViewData["tipo"] = tipo;

                return RedirectToAction(nameof(Perfil));
            }
            catch
            {
                ViewData["id"] = id;
                ViewData["correo"] = correo;
                ViewData["tipo"] = tipo;

                return View();
            }
        }

        // GET: Autores/Delete/5
        public ActionResult Delete(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var autor = context.Autores.Find(new object[] { id });

            autor.Status = 2;
            context.Update(autor);
            context.SaveChanges();

            return RedirectToAction(nameof(Listado));
        }
    }
}