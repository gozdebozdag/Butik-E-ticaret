using BotuqieButik.data.Context;
using BotuqieButik.data.Entitis;
using BotuqieButik.Models;
using Microsoft.AspNetCore.Mvc;

namespace BotuqieButik.Controllers
{
    public class ProductController : Controller
    {
        ProjectContent db = new ProjectContent();

        [HttpGet]
        public IActionResult Index()
        {
            List<Product> productList = db.Products.ToList();


            return View(productList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = db.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Product product = db.Products.Find(id);

            return View(product);

        }

        [HttpPost]

        public IActionResult Update(Product product)
        {
            db.Products.Update(product);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult Delete(int id)
        {
            Product product = db.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            db.Products.Remove(product);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            if (file != null)
            {
                string imageExtension = Path.GetExtension(file.FileName);

                string imageName = Guid.NewGuid() + imageExtension;

                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}");

                using var stream = new FileStream(path, FileMode.Create);

                await file.CopyToAsync(stream);
            }

            return RedirectToAction("UploadImage");
        }




        [HttpGet]
        public IActionResult AssignCategoryToProduct()
        {
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.Products = db.Products.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AssignCategoryToProduct(ProductCategory productCategory)
        {
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.Products = db.Products.ToList();

            if (ModelState.IsValid)
            {
                Product product = db.Products.FirstOrDefault(x => x.Name == productCategory.ProductName);
                product.ProductCategoryId = productCategory.CategoryId;

                db.Products.Update(product);
                db.SaveChanges();

            }

            return RedirectToAction("Index");
        }

        [Route("Product/ProductDetail/{id}")]
        public IActionResult ProductDetail(int Id)
        {           
            Product product = db.Products.FirstOrDefault(x => x.Id == Id);

            ViewBag.Id = product.Id;
            return View(product);
        }

    }
}
