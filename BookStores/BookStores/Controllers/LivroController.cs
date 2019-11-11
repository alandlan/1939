using BookStores.Context;
using BookStores.ViewModels;
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
        readonly BookStoreDataContext _bookStore = new BookStoreDataContext();
        // GET: Livro
        [Route("criar")]
        public ActionResult Create()
        {
            var categorias = _bookStore.Categorias.ToList();
            var model = new CreateBookViewModel
            {
                Nome = "",
                ISBN = "",
                CategoriaId = 0,
                CategoriaOptions = new SelectList(categorias, "Id", "Nome")
            };

            return View(model);
        }

        [Route("criar")]
        [HttpPost]
        public ActionResult Create(CreateBookViewModel modelBook)
        {
            return View();
        }
    }
}