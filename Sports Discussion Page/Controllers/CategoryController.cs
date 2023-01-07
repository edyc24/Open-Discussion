using Microsoft.AspNetCore.Mvc;
using Sports_Discussion_Page.Data;
using Sports_Discussion_Page.Models;

namespace Sports_Discussion_Page.Controllers
{
    public class CategoryController : Controller
    {
        private AppDBContext db = new AppDBContext();

        public IActionResult Select(int id)
        {
            Category category = db.Categories.Find(id);
            ViewBag.Category = category;
            return View();
        }

        public IActionResult Index()
        {
            var categories = db.Categories;
            ViewBag.Categories = categories;
            return View();
        }

        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult New(Category c)
        {
            try
            {
                db.Categories.Add(c);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

    }

}
