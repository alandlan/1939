using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStores.Controllers
{
    [RoutePrefix("Livros")]
    public class LivroController : Controller
    {
        // GET: Livro
        [Route("criar")]
        public ActionResult Create()
        {
            return View();
        }
    }
}