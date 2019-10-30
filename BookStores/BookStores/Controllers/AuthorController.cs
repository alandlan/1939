using BookStores.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStores.Controllers
{
    [RoutePrefix("autor")]
    //[LogActionFilter]
    public class AuthorController : Controller
    {
        [Route("listar")]
        //[LogActionFilter]
        public ActionResult Index()
        {
            return View();
        }

        [Route("criar")]
        public ActionResult Create()
        {
            return View();
        }

        [Route("editar")]
        public ActionResult Edit()
        {
            return View();
        }

        [Route("deletar")]
        public ActionResult Delete()
        {
            return View();
        }
    }
}