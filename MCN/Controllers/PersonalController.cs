using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCN.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCN.Controllers
{
    public class PersonalController : Controller
    {
        [HttpGet]
        public JsonResult LoadData(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var myid = id;
            var list = (from datos in context.CatExtenciones
                        where datos.RInstituciones == myid
                        select new
                        {
                            id = datos.IdExtenciones,
                            nombre = datos.NombreExtencion
                        }).ToList();
            var cadena = "";
            foreach (var x in list)
            {
                cadena = cadena + "<option value='" + x.id + "'>" + x.nombre + "</option>";
            };

            return Json(cadena);
        }

        public ActionResult Listado()
        {

            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int id = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var list = context.Personal.Where(pe => pe.TipoP != 2);

            foreach (Personal p in list)
            {
                //p.RGradoEstudioNavigation = tc.CatGradoEstudio.Where(g => g.IdGradoEst == p.RGradoEstudio).First();
                p.TipoPNavigation = context.TipoPersonal.Where(tp => tp.IdTipoP == p.TipoP).First();
                p.StatusNavigation = context.Estados.Where(s => s.IdEstado == p.Status).First();
                p.RExtencionesPNavigation = context.CatExtenciones.Where(e => e.IdExtenciones == p.RExtencionesP).First();
                p.RExtencionesPNavigation.RInstitucionesNavigation = context.CatInstituciones.Where(i => i.IdInstituto == p.RExtencionesPNavigation.RInstituciones).First();
            }

            ViewData["id"] = id;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View(list);
        }

        // GET: Personal/Details/5
        public ActionResult Detalles(int id)
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int idper = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            Personal persona = context.Personal.Where(pe => pe.TipoP > 1).First();

            persona.RGradoEstudioNavigation = context.CatGradoEstudio.Where(g => g.IdGradoEst == persona.RGradoEstudio).First();
            persona.RLineaTrabajoNavigation = context.CatLineaTrabajo.Where(l => l.IdLineaTrabajp == persona.RLineaTrabajo).First();
            persona.RExtencionesPNavigation = context.CatExtenciones.Where(e => e.IdExtenciones == persona.RExtencionesP).First();
            persona.RExtencionesPNavigation.RInstitucionesNavigation = context.CatInstituciones.Where(i => i.IdInstituto == persona.RExtencionesPNavigation.RInstituciones).First();


            ViewData["id"] = idper;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View(persona);
        }

        // GET: Personal/Create
        [Authorize]
        public ActionResult RegistrarPersonal()
        {

            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int idper = (int)HttpContext.Session.GetInt32("id");

            var tc = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;

            //ViewBag.idInstituciones = tc.CatInstituciones.Select(i => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = i.NombreInstituto, Value = i.IdInstituto.ToString() });
            ViewBag.TipoP = tc.TipoPersonal.Select(tp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = tp.TipoUsuarios, Value = tp.IdTipoP.ToString() });
            ViewBag.IdInstituciones = tc.CatInstituciones.Select(ci => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ci.NombreInstituto, Value = ci.IdInstituto.ToString() });
            ViewBag.IdExtenciones = tc.CatExtenciones.Select(e => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = e.NombreExtencion, Value = e.IdExtenciones.ToString() });
            ViewBag.IdGradoEst = tc.CatGradoEstudio.Select(g => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = g.NivelEstudio, Value = g.IdGradoEst.ToString() });
            ViewBag.IdLineaTrabajp = tc.CatLineaTrabajo.Select(l => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = l.LineasTrabajo, Value = l.IdLineaTrabajp.ToString() });


            ViewData["id"] = idper;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View();
        }

        // POST: Personal/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegistrarPersonal(Personal personal)
        {
            try
            {
                // TODO: Add insert logic here
                var tc = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
                personal.Status = 1;

                tc.Personal.Add(personal);
                tc.SaveChanges();
                return RedirectToAction(nameof(Listado));
            }
            catch (Exception ex)
            {
                string correo = HttpContext.Session.GetString("Correo");
                string pass = HttpContext.Session.GetString("pass");
                int tipo = (int)HttpContext.Session.GetInt32("tipo");
                int idper = (int)HttpContext.Session.GetInt32("id");

                var tc = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;

                //ViewBag.idInstituciones = tc.CatInstituciones.Select(i => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = i.NombreInstituto, Value = i.IdInstituto.ToString() });
                ViewBag.Tipo = tc.TipoPersonal.Select(tp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = tp.TipoUsuarios, Value = tp.IdTipoP.ToString() });
                ViewBag.IdInstituciones = tc.CatInstituciones.Select(ci => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ci.NombreInstituto, Value = ci.IdInstituto.ToString() });
                ViewBag.IdExtenciones = tc.CatExtenciones.Select(e => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = e.NombreExtencion, Value = e.IdExtenciones.ToString() });
                ViewBag.IdGradoEst = tc.CatGradoEstudio.Select(g => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = g.NivelEstudio, Value = g.IdGradoEst.ToString() });
                ViewBag.IdLineaTrabajp = tc.CatLineaTrabajo.Select(l => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = l.LineasTrabajo, Value = l.IdLineaTrabajp.ToString() });


                ViewData["id"] = idper;
                ViewData["correo"] = correo;
                ViewData["tipo"] = tipo;

                return View();
            }
        }

        public ActionResult Perfil()
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int idper = (int)HttpContext.Session.GetInt32("id");

            var tc = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            Personal personal = tc.Personal.Where(p=> p.IdPersonal == idper && p.TipoP== tipo & p.Status!=2).First();

            personal.RExtencionesPNavigation = tc.CatExtenciones.Where(ex => ex.IdExtenciones == personal.RExtencionesP).First();
            personal.RGradoEstudioNavigation = tc.CatGradoEstudio.Where(g => g.IdGradoEst == personal.RGradoEstudio).First();
            personal.RLineaTrabajoNavigation = tc.CatLineaTrabajo.Where(lt => lt.IdLineaTrabajp == personal.RLineaTrabajo).First();
            personal.TipoPNavigation = tc.TipoPersonal.Where(tp => tp.IdTipoP == personal.TipoP).First();
            personal.StatusNavigation = tc.Estados.Where(es => es.IdEstado == personal.RGradoEstudio).First();
            personal.RExtencionesPNavigation.RInstitucionesNavigation = tc.CatInstituciones.Where(ins => ins.IdInstituto == personal.RExtencionesPNavigation.RInstituciones).First();

            ViewData["id"] = idper;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View(personal);
        }

        // GET: Personal/Edit/5
        public ActionResult Configuracion()
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int idper = (int)HttpContext.Session.GetInt32("id");

            var tc = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            Personal personal = tc.Personal.Where(p => p.IdPersonal == idper && p.TipoP == tipo & p.Status != 2).First();

            ViewBag.Tipo = tc.TipoPersonal.Select(tp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = tp.TipoUsuarios, Value = tp.IdTipoP.ToString() });
            ViewBag.IdInstituciones = tc.CatInstituciones.Select(ci => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ci.NombreInstituto, Value = ci.IdInstituto.ToString() });
            ViewBag.IdExtenciones = tc.CatExtenciones.Select(e => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = e.NombreExtencion, Value = e.IdExtenciones.ToString() });
            ViewBag.IdGradoEst = tc.CatGradoEstudio.Select(g => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = g.NivelEstudio, Value = g.IdGradoEst.ToString() });
            ViewBag.IdLineaTrabajp = tc.CatLineaTrabajo.Select(l => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = l.LineasTrabajo, Value = l.IdLineaTrabajp.ToString() });
            personal.StatusNavigation = tc.Estados.Where(es => es.IdEstado == personal.RGradoEstudio).First();

            ViewData["id"] = idper;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View(personal);
        }

        // POST: Personal/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Configuracion(Personal personal)
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int idper = (int)HttpContext.Session.GetInt32("id");

            try
            {
                // TODO: Add update logic here
                var tc = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
                var personalInfo = tc.Personal.Find(new object[] { idper });

                personalInfo.NombreP = personal.NombreP;
                personalInfo.ApellidoP = personal.ApellidoP;
                personalInfo.NombreUsuarioP = personal.NombreUsuarioP;
                personalInfo.CorreoElectronicoP = personal.CorreoElectronicoP;

                if (personal.Contrasenia != null)
                    personalInfo.Contrasenia = personal.Contrasenia;

                personalInfo.RExtencionesP = personal.RExtencionesP;
                personalInfo.RGradoEstudio = personal.RGradoEstudio;
                personalInfo.RLineaTrabajo = personal.RLineaTrabajo;

                tc.Update(personalInfo);
                tc.SaveChanges();

                ViewData["id"] = idper;
                ViewData["correo"] = correo;
                ViewData["tipo"] = tipo;

                return RedirectToAction(nameof(Perfil));
            }
            catch
            {

                return RedirectToAction(nameof(Configuracion));
            }
        }

        // GET: Personal/Delete/5


        public ActionResult Delete(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var super = context.Personal.Find(new object[] { id });

            super.Status = 2;
            context.Update(super);
            context.SaveChanges();

            return RedirectToAction(nameof(Listado));
        }

        public ActionResult Activate(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var super = context.Personal.Find(new object[] { id });

            super.Status = 1;
            context.Update(super);
            context.SaveChanges();

            return RedirectToAction(nameof(Listado));
        }
    }
}