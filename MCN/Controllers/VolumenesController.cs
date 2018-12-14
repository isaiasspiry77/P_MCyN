using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCN.Controllers
{
    public class VolumenesController : Controller
    {
        // GET: Volumenes
        public ActionResult Volumenes()
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int id = (int)HttpContext.Session.GetInt32("id");

            ViewData["id"] = id;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View();
        }

        // GET: Volumenes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Volumenes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Volumenes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Volumenes));
            }
            catch
            {
                return View();
            }
        }

        // GET: Volumenes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Volumenes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Volumenes));
            }
            catch
            {
                return View();
            }
        }

        // GET: Volumenes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Volumenes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Volumenes));
            }
            catch
            {
                return View();
            }
        }
    }
}