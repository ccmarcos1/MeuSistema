using MVCMeuSistema.Models;
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
            var lista = Produtos.GetProdutos();
            ViewBag.Lista = lista;
            return View();
        }
        public ActionResult Cliente()
        {
            return View();
        }
    }
}