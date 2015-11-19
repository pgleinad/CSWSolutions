using BookLibraryAPI.Models;
using BookLibraryWeb.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BookLibraryWeb.Controllers
{
    public class CategoryController : Controller
    {
        public ActionResult Index()
        {
            List<Category> categories = new CategoryAPI().get();
            return View(categories);
        }

        public ActionResult Details(Guid id)
        {
            Category category = new CategoryAPI().get(id);
            return View(category);
        }

        public async Task<ActionResult> Create(Category category)
        {
            return View();
        }

        public async Task<ActionResult> CreateSave(Category category)
        {
            category.Id = Guid.NewGuid();
            new CategoryAPI().add(category);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(Guid id)
        {
            Category category = new CategoryAPI().get(id);
            return View(category);
        }

        public async Task<ActionResult> EditSave(Category category)
        {
            new CategoryAPI().update(category);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Delete(Guid id)
        {
            new CategoryAPI().delete(id);
            return RedirectToAction("Index");
        }
    }
}