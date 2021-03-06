﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MCN.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCN.Controllers
{
    public class ArticulosController : Controller
    {
        // GET: Articulos
        public ActionResult Listado()
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int id = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var list = context.Articulo.Where(ar => ar.Status != 2);

            int c = 0;

            foreach (Articulo a in list)
            {
                a.RAutorNavigation = context.Autores.Where(au => au.IdAutores == a.RAutor).First();
                a.StatusNavigation = context.Estados.Where(es => es.IdEstado == a.Status).First();
                if(a.FechaEdicionA != null)
                {
                    c++;
                }
            }

            ViewData["id"] = id;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;
            ViewData["edicion"] = c;

            return View(list);
        }

        public ActionResult ListadoAceptados()
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int id = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var list = context.Articulo.Where(ar => ar.Status == 9);

            foreach (Articulo a in list)
            {
                a.RAutorNavigation = context.Autores.Where(au => au.IdAutores == a.RAutor).First();
                a.StatusNavigation = context.Estados.Where(es => es.IdEstado == a.Status).First();
            }

            ViewData["id"] = id;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View(list);
        }

        public ActionResult ListadoAutor()
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int id = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var list = context.Articulo.Where(ar => ar.RAutor == id && ar.Status != 2);

            foreach (Articulo a in list)
            {
                a.RAutorNavigation = context.Autores.Where(au => au.IdAutores == a.RAutor).First();
                a.StatusNavigation = context.Estados.Where(e => e.IdEstado == a.Status).First();
            }

            ViewData["id"] = id;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View(list);
        }

        public ActionResult ListadoRevisores()
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int id = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var list = context.DetalleArticulos.Where(da => da.IdPersonal == id);

            foreach (DetalleArticulos d in list)
            {
                d.IdArticuloNavigation = context.Articulo.Where(ar => ar.IdArticulo == d.IdArticulo).First();
                d.IdPersonalNavigation = context.Personal.Where(p => p.IdPersonal == id).First();
                d.StatusNavigation = context.Estados.Where(e => e.IdEstado == d.Status).First();
            }

            ViewData["id"] = id;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View(list);
        }

        [HttpGet]
        public ActionResult SubirArticulo()
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

        private IHostingEnvironment _hostingEnv;
        public ArticulosController(IHostingEnvironment hostingEnv)
        {
            _hostingEnv = hostingEnv;
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubirArticulo(string titulo, IFormFile urlPdf, IFormFile urlImg, string coment, int[] coautor=null)
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int id = (int)HttpContext.Session.GetInt32("id");

            try
            {
                var PdfName = ContentDispositionHeaderValue.Parse(urlPdf.ContentDisposition.ToString()).FileName.Trim('"');
                var RootPath = _hostingEnv.WebRootPath;
                var pdfFullPath = Path.Combine(RootPath, "PdfUploaded");

                if (!Directory.Exists(pdfFullPath))
                {
                    Directory.CreateDirectory(pdfFullPath);
                }

                var pdfFullName = pdfFullPath + Path.DirectorySeparatorChar + PdfName;
                using (var stream = new FileStream(pdfFullName, FileMode.Create))
                    await urlPdf.CopyToAsync(stream);


                var ZipName = ContentDispositionHeaderValue.Parse(urlImg.ContentDisposition.ToString()).FileName.Trim('"');
                var imgFullPath = Path.Combine(RootPath, "ZipUploaded");

                if (!Directory.Exists(imgFullPath))
                {
                    Directory.CreateDirectory(imgFullPath);
                }

                var imgFullName = imgFullPath + Path.DirectorySeparatorChar + ZipName;
                using (var stream2 = new FileStream(imgFullName, FileMode.Create))
                    await urlImg.CopyToAsync(stream2);


                var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
                Articulo articulo = new Articulo();

                articulo.TituloArticulo = titulo;
                articulo.RutaDocumentoA = pdfFullName;
                articulo.RutaZipImagenesA = imgFullName;
                articulo.ComentariosAutor = coment;

                DateTime dateNow = DateTime.Now.Date;
                string formatMysql = dateNow.ToString("dd-MM-yyyy");
                articulo.FechaPublicacionA = formatMysql;

                articulo.RAutor = id;
                articulo.Status = 8;

                context.Articulo.Add(articulo);
                context.SaveChanges();

                //hechizo de coautores
                if (coautor != null)
                {
                    foreach (int v in coautor)
                    {
                        var c = context.Coautores.Find(new object[] { v });
                        int idar = context.Articulo.OrderByDescending(x => x.IdArticulo).First().IdArticulo;
                        c.RArticulo = idar;
                        context.Update(c);
                        context.SaveChanges();
                    }
                }

                ViewData["id"] = id;
                ViewData["correo"] = correo;
                ViewData["tipo"] = tipo;

                return View();
            }
            catch
            {
                ViewData["id"] = id;
                ViewData["correo"] = correo;
                ViewData["tipo"] = tipo;

                return View();
            }
        }

        byte[] GetFile(string s) {
            System.IO.FileStream fs = System.IO.File.OpenRead(s);
            byte[] data = new byte[fs.Length];
            int br = fs.Read(data, 0, data.Length);
            if (br != fs.Length)
                throw new System.IO.IOException(s);
            return data;
        }

        [HttpGet]
        public FileContentResult DownloadPdf(string fullPath)
        {
            byte[] filebyte = GetFile(fullPath);
            return File(filebyte, System.Net.Mime.MediaTypeNames.Application.Octet, "ArchivodePublicacion.pdf");
        }

        public FileContentResult DownloadZip(string fullPath)
        {
            byte[] filebyte = GetFile(fullPath);
            return File(filebyte, System.Net.Mime.MediaTypeNames.Application.Octet, "ImagenesdePublicacion.zip");
        }

        public FileContentResult DownloadArchivo(string fullPath)
        {
            byte[] filebyte = GetFile(fullPath);
            return File(filebyte, System.Net.Mime.MediaTypeNames.Application.Octet, "ComentariosRevision.docx");
        }

        // GET: Articulos/Details/5
        public ActionResult Asignacion(int id)
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int idper = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            Articulo articulo = context.Articulo.Where(ar => ar.IdArticulo == id).First();

            if (articulo == null) RedirectToAction(nameof(Listado));

            articulo.RAutorNavigation = context.Autores.Where(au => au.IdAutores == articulo.RAutor).First();
            ViewBag.Estados = context.Estados.Where(es => es.IdEstado != 9 && es.IdEstado > 6 && es.IdEstado<11).Select(e => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = e.DescEstados, Value = e.IdEstado.ToString() });

            ViewData["id"] = idper;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View(articulo);
        }


        // POST: Articulos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Asignacion(int id, Articulo articulo, string textcoment)
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int idper = (int)HttpContext.Session.GetInt32("id");

            try
            {
                // TODO: Add update logic here

                var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
                var arti = context.Articulo.Find(new object[] { id });

                DetalleArticulos detalleArticulo = new DetalleArticulos();
                detalleArticulo.IdPersonal = idper;
                detalleArticulo.IdArticulo = id;
                DateTime dateNow = DateTime.Now.Date;
                string formatMysql = dateNow.ToString("dd-MM-yyyy");
                detalleArticulo.FechaRevision = formatMysql; 
                detalleArticulo.ComentariosRetroaliment = textcoment;
                detalleArticulo.Status = 7;

                context.DetalleArticulos.Add(detalleArticulo);
                context.SaveChanges();

                if (articulo.Status == 10)
                {
                    arti.Status = articulo.Status;
                    context.Update(arti);
                    context.SaveChanges();

                    return RedirectToAction(nameof(Listado));
                }

                arti.Status = articulo.Status;
                context.Update(arti);
                context.SaveChanges();
                if (textcoment != null)
                {
                    HttpContext.Session.SetString("coment", textcoment);
                }
                if (id != 0)
                {
                    HttpContext.Session.SetInt32("idArti", id);
                }

                return RedirectToAction(nameof(RevisoresDisponibles));
            }
            catch
            {
                return RedirectToAction(nameof(Asignacion));
            }
        }

        // GET: Articulos/5
        public ActionResult RevisoresDisponibles()
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int idper = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var list = context.Personal.Where(pe => pe.TipoP == 3 && pe.Status == 1);

            foreach (Personal p in list)
            {
                p.RLineaTrabajoNavigation = context.CatLineaTrabajo.Where(lt => lt.IdLineaTrabajp == p.RLineaTrabajo).First();
                p.TipoPNavigation = context.TipoPersonal.Where(tp => tp.IdTipoP == p.TipoP).First();
                p.StatusNavigation = context.Estados.Where(s => s.IdEstado == p.Status).First();
                p.RExtencionesPNavigation = context.CatExtenciones.Where(e => e.IdExtenciones == p.RExtencionesP).First();
                p.RExtencionesPNavigation.RInstitucionesNavigation = context.CatInstituciones.Where(i => i.IdInstituto == p.RExtencionesPNavigation.RInstituciones).First();
            }

            ViewData["id"] = idper;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            if (HttpContext.Session.GetInt32("idArti") != 0 || HttpContext.Session.GetInt32("idArti") != null) {
                ViewData["idArt"] = (int)HttpContext.Session.GetInt32("idArti");
                HttpContext.Session.Remove("idArti");
            }

            if (HttpContext.Session.GetString("coment") != null)
            {
                ViewData["coment"] = HttpContext.Session.GetString("coment");
                HttpContext.Session.Remove("coment");
            }

            return View(list);
        }

        // POST: Articulos/Delete/5
        [HttpGet]
        public ActionResult AsignacionRevisores(int id_per, int id_articulo, string comentariomemo)
        {
            try
            {
                // TODO: Add delete logic here
                var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;

                var articulo = context.Articulo.Find(new object[] { id_articulo });
                articulo.Status = 7;
                context.Update(articulo);
                context.SaveChanges();

                DetalleArticulos detalle = new DetalleArticulos();

                detalle.Status = 7;
                detalle.IdPersonal = id_per;
                detalle.IdArticulo = id_articulo;

                context.DetalleArticulos.Add(detalle);
                context.SaveChanges();

                if (comentariomemo != null)
                {
                    HttpContext.Session.SetString("comentariomemo", comentariomemo);
                }

                return RedirectToAction(nameof(Listado));
            }
            catch
            {
                HttpContext.Session.SetInt32("idArti", id_articulo);
                HttpContext.Session.SetString("coment", comentariomemo);

                return RedirectToAction(nameof(RevisoresDisponibles));
            }
        }

        public ActionResult DetalleArticulo(int id)
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int idper = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var Listdetalle = context.DetalleArticulos.Where(d => d.IdArticulo == id);

            if (Listdetalle == null)
            {
                return RedirectToAction("Asignacion", "Articulos", new { id_art = id });
            }

            foreach (DetalleArticulos d in Listdetalle)
            {
                d.IdArticuloNavigation = context.Articulo.Where(ar => ar.IdArticulo == d.IdArticulo).First();
                d.IdPersonalNavigation = context.Personal.Where(per => per.IdPersonal == d.IdPersonal).First();
            }

            ViewData["id"] = idper;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;
            ViewData["idArt"] = id;

            return View(Listdetalle);
        }

        public ActionResult DetalleArticuloAutor(int id)
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int idau = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var articulo = context.Articulo.Where(ar => ar.IdArticulo == id && ar.Status != 2).First();

            articulo.RAutorNavigation = context.Autores.Where(au => au.IdAutores == idau).First();
            articulo.StatusNavigation = context.Estados.Where(e => e.IdEstado == articulo.Status).First();

            ViewData["id"] = idau;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View(articulo);
        }

        public ActionResult DetalleArticuloRevisor(int id)
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int idper = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var c = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            DetalleArticulos articulo = context.DetalleArticulos.Find(new object[] { id });

            var id_ar = articulo.IdArticulo;
            var list = context.DetalleArticulos.Where(da => da.IdArticulo == id_ar);
            DetalleArticulos articulod = null;

            foreach (DetalleArticulos d in list)
            {
                d.IdPersonalNavigation = context.Personal.Where(pi => pi.IdPersonal == d.IdPersonal).First();
                if (d.IdPersonalNavigation.TipoP ==2 || d.IdPersonalNavigation.TipoP == 5)
                {
                    articulod = d;
                }
            }

            articulod.IdArticuloNavigation = context.Articulo.Where(ar => ar.IdArticulo == articulod.IdArticulo).First();
            articulod.StatusNavigation = context.Estados.Where(e => e.IdEstado == articulod.Status).First();
            articulod.IdArticuloNavigation.RAutorNavigation = context.Autores.Where(au => au.IdAutores == articulod.IdArticuloNavigation.RAutor).First();

            ViewData["id"] = idper;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View(articulod);
        }

        public ActionResult Revisar(int id)
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int idper = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var detalle = context.DetalleArticulos.Where(d => d.IdDetalleArt == id).First();

            detalle.IdArticuloNavigation = context.Articulo.Where(ar => ar.IdArticulo == detalle.IdArticulo).First();
            detalle.IdPersonalNavigation = context.Personal.Where(per => per.IdPersonal == detalle.IdPersonal).First();
            ViewBag.Estados = context.Estados.Where(es => es.IdEstado >= 9).Select(e => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = e.DescEstados, Value = e.IdEstado.ToString() });

            ViewData["id"] = idper;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View(detalle);
        }

        [HttpPost]
        public async Task<IActionResult> Revisar(DetalleArticulos detalleArticulos, IFormFile comentario)
        {

            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
                var detalle = context.DetalleArticulos.Find(new object[] { detalleArticulos.IdDetalleArt });

                if (comentario != null)
                {
                    var ComentName = ContentDispositionHeaderValue.Parse(comentario.ContentDisposition.ToString()).FileName.Trim('"');
                    var RootPath = _hostingEnv.WebRootPath;
                    var ComentFullPath = Path.Combine(RootPath, "ComentsUploaded");

                    if (!Directory.Exists(ComentFullPath))
                    {
                        Directory.CreateDirectory(ComentFullPath);
                    }

                    var ComentFullName = ComentFullPath + Path.DirectorySeparatorChar + ComentName;
                    using (var stream = new FileStream(ComentFullName, FileMode.Create))
                        await comentario.CopyToAsync(stream);

                    detalle.ComentariosRetroaliment = ComentFullName;
                    detalle.Status = detalleArticulos.Status;

                    DateTime dateNow = DateTime.Now.Date;
                    string formatMysql = dateNow.ToString("dd-MM-yyyy");

                    detalle.FechaRevision = formatMysql;
                    context.Update(detalle);
                    context.SaveChanges();

                    return RedirectToAction(nameof(ListadoRevisores));
                }
                return RedirectToAction(nameof(Revisar));
            }
            catch
            {
                return RedirectToAction(nameof(Revisar));
            }
        }

        [HttpGet]
        public ActionResult EditarArticulo(int id)
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int idper = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            Articulo articuloedi = context.Articulo.Where(ar => ar.IdArticulo == id).First();

            ViewData["id"] = idper;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View(articuloedi);
        }

        [HttpPost]
        public async Task <IActionResult> EditarArticulo(int id_ar, string titulo, IFormFile urlPdf, IFormFile urlImg, string coment)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
                var artiviejo = context.Articulo.Find(new object[] { id_ar });

                artiviejo.TituloArticulo = titulo;

                if(urlPdf != null)
                {
                    var PdfName = ContentDispositionHeaderValue.Parse(urlPdf.ContentDisposition.ToString()).FileName.Trim('"');
                    var RootPath = _hostingEnv.WebRootPath;
                    var pdfFullPath = Path.Combine(RootPath, "PdfUploaded");

                    if (!Directory.Exists(pdfFullPath))
                    {
                        Directory.CreateDirectory(pdfFullPath);
                    }

                    var pdfFullName = pdfFullPath + Path.DirectorySeparatorChar + PdfName;
                    using (var stream = new FileStream(pdfFullName, FileMode.Create))
                        await urlPdf.CopyToAsync(stream);

                    artiviejo.RutaDocumentoA = pdfFullName;
                }
                if (urlImg != null)
                {
                    var ZipName = ContentDispositionHeaderValue.Parse(urlImg.ContentDisposition.ToString()).FileName.Trim('"');
                    var RootPath = _hostingEnv.WebRootPath;
                    var imgFullPath = Path.Combine(RootPath, "ZipUploaded");

                    if (!Directory.Exists(imgFullPath))
                    {
                        Directory.CreateDirectory(imgFullPath);
                    }

                    var imgFullName = imgFullPath + Path.DirectorySeparatorChar + ZipName;
                    using (var stream2 = new FileStream(imgFullName, FileMode.Create))
                        await urlImg.CopyToAsync(stream2);

                    artiviejo.RutaZipImagenesA = imgFullName;
                }

                artiviejo.ComentariosAutor = coment;

                DateTime dateNow = DateTime.Now.Date;
                string formatMysql = dateNow.ToString("dd-MM-yyyy");

                artiviejo.FechaEdicionA = formatMysql;
                artiviejo.Status = 8;

                context.Update(artiviejo);
                context.SaveChanges();

                return RedirectToAction(nameof(ListadoAutor));
            }
            catch {
                return RedirectToAction(nameof(EditarArticulo));
            }
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var articulo = context.Articulo.Find(new object[] { id });

            articulo.Status = 2;
            context.Update(articulo);
            context.SaveChanges();

            return RedirectToAction(nameof(ListadoAutor));
        }

        public ActionResult Intermedio(int id)
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int idper = (int)HttpContext.Session.GetInt32("id");

            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var articulo = context.Articulo.Where(ar => ar.IdArticulo == id).First();

            articulo.RAutorNavigation = context.Autores.Where(au => au.IdAutores == articulo.RAutor).First();
            ViewBag.Estados = context.Estados.Where(es => es.IdEstado >9).Select(e => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = e.DescEstados, Value = e.IdEstado.ToString() });

            ViewData["id"] = idper;
            ViewData["correo"] = correo;
            ViewData["tipo"] = tipo;

            return View(articulo);
        }

        [HttpPost]
        public ActionResult Intermedio(Articulo articulo)
        {
            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            var artiviejo = context.Articulo.Find(new object[] { articulo.IdArticulo});

            artiviejo.Status = articulo.Status;

            context.Update(artiviejo);
            context.SaveChanges();

            return RedirectToAction(nameof(Listado));

        }
    }
}