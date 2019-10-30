using BookStores.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStores.Controllers
{
    [RoutePrefix("teste")]
    [Route("{action=Dados}")] //troca para a rota padrao
    public class TesteController : Controller
    {
        public ViewResult Dados(int id)
        {
            var autor = new Autor
            {
                Id = 1,
                Nome = "Alan Martins"
            };

            ViewBag.Categoria = "Produtos de limpeza";
            ViewData["Categoria"] = "Produtos de informatica";
            TempData["Categoria"] = "Produtos de escritorio";
            Session["Categoria"] = "Produtos de estudo.";

            return View(autor);
        }
        public JsonResult UmaAction(int id, string nome)
        {
            var autor = new Autor
            {
                Id = id,
                Nome = nome
            };

            return Json(autor, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ActionName("Autor")]
        public JsonResult ActionDois(Autor autor)
        {
            return Json(autor);
        }
        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }

        // GET: Teste/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Teste/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teste/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Teste/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Teste/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Teste/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Teste/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [Route("teste/minharota/{id:int}")]
        public string MinhaAction(int id)
        {
            return "Ok! Cheguei na rota!";
        }

        [Route("~/rotaignorada/{id:int}")]
        public string MinhaAction2(int id)
        {
            return "Ok! Cheguei na rota!";
        }

        [Route("rota/{categoria:minlength(3)}")]
        public string MinhaAction3(string categoria)
        {
            return "Ok! Cheguei na rota!" + categoria;
        }

        [Route("rota/{categoria:alpha:minlength(3)}")]
        public string MinhaAction4(string categoria)
        {
            return "Ok! Cheguei na rota!" + categoria;
        }

        //[Route("rota4/{estacao:(primavera|verao|outuno|inverno)}")]
        //public string MinhaAction5(string estacao)
        //{
        //    return "Olá, estamos no " + estacao;
        //}
    }
}
