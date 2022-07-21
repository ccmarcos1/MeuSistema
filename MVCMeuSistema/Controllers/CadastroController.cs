using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMeuSistema.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Produto()
        {
            return View();
        }
        public ActionResult Cliente()
        {
            return View();
        }
    }
}