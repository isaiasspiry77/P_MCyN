using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MCN.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCN.Controllers
{
    public class AccountController : Controller
    {
        // GET: Login
        [HttpGet]
        public IActionResult Login(string returnURL)
        {
            if (User.Identity.IsAuthenticated == false)
            {
                if (returnURL != null)
                    ViewData.Add("ReturnURL", returnURL);
                else
                    ViewData.Add("ReturnURL", "");

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
                Autores autores = context.Autores.Where(au => au.CorreoElectronicoA == model.Email && au.ContraseniaA == model.Password && au.Status == 1).FirstOrDefault();
                if (autores != null)
                {
                    var claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Name, model.Email));
                    var userIdentity = new ClaimsIdentity(claims, "login");
                    var principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync("PKAT", principal);

                    //if (model.ReturnURL == "")
                    //    return Redirect(model.ReturnURL);
                    //else

                    HttpContext.Session.SetString("Correo", autores.CorreoElectronicoA);
                    HttpContext.Session.SetString("pass", autores.ContraseniaA);
                    HttpContext.Session.SetInt32("tipo", autores.TipoA);
                    HttpContext.Session.SetInt32("id", autores.IdAutores);

                    return RedirectToAction("Index", "Home");
                }
                else if (autores == null)
                {
                    Personal personal = context.Personal.Where(pe => pe.CorreoElectronicoP == model.Email && pe.Contrasenia == model.Password && pe.Status == 1).FirstOrDefault();
                    if (personal != null)
                    {
                        var claims = new List<Claim>();
                        claims.Add(new Claim(ClaimTypes.Name, model.Email));
                        var userIdentity = new ClaimsIdentity(claims, "login");
                        var principal = new ClaimsPrincipal(userIdentity);
                        await HttpContext.SignInAsync("PKAT", principal);

                        HttpContext.Session.SetString("Correo", personal.CorreoElectronicoP);
                        HttpContext.Session.SetString("pass", personal.Contrasenia);
                        HttpContext.Session.SetInt32("tipo", personal.TipoP);
                        HttpContext.Session.SetInt32("id", personal.IdPersonal);


                        return RedirectToAction("Index", "Home");
                    }
                    return RedirectToAction("Login", "Account");
                }
            }

            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public async Task<IActionResult> Logaout()
        {
            await HttpContext.SignOutAsync("PKAT");

            HttpContext.Session.Remove("correo");
            HttpContext.Session.Remove("pass");
            HttpContext.Session.Remove("tipo");
            HttpContext.Session.Remove("id");

            return Redirect("/Account/Login");
        }

        [HttpGet]
        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Registro(Autores autor)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
                autor.TipoA = 1;
                autor.Status = 1;

                context.Autores.Add(autor);
                context.SaveChanges();

                return RedirectToAction("Login", "Account");
            }
            catch
            {
                return View();
            }
        }
    }
}