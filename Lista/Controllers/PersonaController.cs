using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Lista.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Humano()
        {
            return View();
        }
        public ActionResult VistaListaPersonas()
        {
            return View();
        }
    }
}