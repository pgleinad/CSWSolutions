using BookLibraryAPI.Models;
using BookLibraryWeb.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace BookLibraryWeb.Controllers
{
    public class AuthorController : Controller
    {
        public ActionResult Index()
        {
            List<Author> authors = new AuthorAPI().get();
            return View(authors);
        }

        public ActionResult Details(Guid id)
        {
            Author author = new AuthorAPI().get(id);
            return View(author);
        }

        public async Task<ActionResult> Create(Author author)
        {
            return View();
        }

        public async Task<ActionResult> CreateSave(Author author)
        {
            author.Id = Guid.NewGuid();
            new AuthorAPI().add(author);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(Guid id)
        {
            Author author = new AuthorAPI().get(id);
            return View(author);
        }

        public async Task<ActionResult> EditSave(Author author)
        {
            new AuthorAPI().update(author);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Delete(Guid id)
        {
            new AuthorAPI().delete(id);
            return RedirectToAction("Index");
        }
    }
}