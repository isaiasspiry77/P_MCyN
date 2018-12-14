using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCN.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MCN.Controllers
{
    public class CoautoresController : Controller
    {
        // GET: Coautores
        [HttpGet]
        public int AgregarCoautor(string nombre, string apellido, string email)
        {
            string correo = HttpContext.Session.GetString("Correo");
            string pass = HttpContext.Session.GetString("pass");
            int tipo = (int)HttpContext.Session.GetInt32("tipo");
            int id = (int)HttpContext.Session.GetInt32("id");
            
            var context = HttpContext.RequestServices.GetService(typeof(proyecto_r_mcynContext)) as proyecto_r_mcynContext;
            Coautores coautor = new Coautores();

            coautor.NombreCa = nombre;
            coautor.ApellidosCa = apellido;
            coautor.CorreoElectronico = email;
            coautor.Status = 1;
            coautor.Rtipo = 6;
            coautor.RAutor = id;

            context.Coautores.Add(coautor);
            context.SaveChanges();

            int idco= context.Coautores.OrderByDescending(x => x.IdCoautores).First().IdCoautores;

            return idco;
        }
    }
}