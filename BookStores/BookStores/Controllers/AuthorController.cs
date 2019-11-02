using BookStores.Domain;
using BookStores.Filters;
using BookStores.Repositories;
using BookStores.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStores.Controllers
{
    
    [RoutePrefix("autores")]
    //[LogActionFilter]
    public class AuthorController : Controller
    {
        private IAuthorRepository repository;

        public AuthorController()
        {
            repository = new AuthorRepository();
        }

        [Route("listar")]
        //[LogActionFilter]
        public ActionResult Index()
        {
            var autores = repository.Get();
            return View(autores);
        }

        [Route("criar")]
        [HttpPost]
        public ActionResult Create(Autor author)
        {
            if (repository.Create(author))
                return RedirectToAction("Index");

            return View(author);
        }

        [Route("editar/{id:int}")]
        public ActionResult Edit(int id)
        {
            var author = repository.Get(id);
            return View(author);
        }

        [Route("editar/{id:int}")]
        [HttpPost]
        public ActionResult Edit(Autor author)
        {
            if (repository.Update(author))
                return RedirectToAction("Index");

            return View(author);
        }

        [Route("excluir/{id:int}")]
        public ActionResult Delete(int id)
        {
            var author = repository.Get(id);
            return View(author);
        }

        [Route("excluir/{id:int}")]
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}