using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppTurmaB.Models;
using System.Web.Mvc;
using System.Collections.ObjectModel;

namespace AppTurmaB.Controllers
{
    public class FuncionarioController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", funcionario);
            }
            return View();
        }

        public ActionResult ValidaLogin(string Login)
        {
            var dbExemplo = new Collection<string>
            {
                "Lety",
                "Arthur",
                "Shen"
            };

            return Json(dbExemplo.All(a => a.ToLower() != Login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}