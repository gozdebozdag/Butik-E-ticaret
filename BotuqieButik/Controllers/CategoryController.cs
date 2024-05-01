using BotuqieButik.data.Context;
using BotuqieButik.data.Entitis;
using Microsoft.AspNetCore.Mvc;

namespace BotuqieButik.Controllers
{
    public class CategoryController : Controller
    {
        ProjectContent db = new ProjectContent();

        [HttpGet]
        public IActionResult Index()
        {
            List<Category> categoryList = db.Categories.ToList();


            return View(categoryList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Category category = db.Categories.Find(id);

            return View(category);

        }

        [HttpPost]

        public IActionResult Update(Category category)
        {
            db.Categories.Update(category);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult Delete(int id)
        {
            Category category = db.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            db.Categories.Remove(category);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    
    }
}
