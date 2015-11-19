using BookLibraryAPI.Models;
using BookLibraryWeb.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BookLibraryWeb.Controllers
{
    public class BookController : Controller
    {
        public ActionResult Index()
        {
            List<Book> books = new BookAPI().get();
            return View(books);
        }

        public ActionResult SearchByAuthor()
        {
            List<Author> authors = new AuthorAPI().get();
            return View(authors);
        }

        public ActionResult SearchAuthor(Guid authorId)
        {
            ViewBag.Authors = new AuthorAPI().get();
            List<Book> books = new BookAPI().getByAuthor(authorId);
            return View(books);
        }

        public ActionResult IndexByAuthor(Guid authorId)
        {
            List<Book> books = new BookAPI().getByAuthor(authorId);
            return View(books);
        }

        public ActionResult Details(Guid id)
        {
            Book book = new BookAPI().get(id);
            return View(book);
        }

        public ActionResult Create(Book book)
        {
            ViewBag.Authors = new AuthorAPI().get();
            ViewBag.Categories = new CategoryAPI().get();
            return View();
        }

        public async Task<ActionResult> CreateSave(Book book)
        {
            book.id = Guid.NewGuid();
            new BookAPI().add(book);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(Guid id)
        {
            Book book = new BookAPI().get(id);
            return View(book);
        }

        public async Task<ActionResult> EditSave(Book book)
        {
            new BookAPI().update(book);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Delete(Guid id)
        {
            new BookAPI().delete(id);
            return RedirectToAction("Index");
        }
    }
}