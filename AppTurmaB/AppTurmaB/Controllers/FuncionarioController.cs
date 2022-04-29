using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppTurmaB.Models;
using System.Web.Mvc;

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
    }
}