using Business.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MVCProjeKamp.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCategoryList()
        {
            var categoryValues = categoryManager.GetAll();
            return View(categoryValues);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            categoryManager.Add(category);
            return RedirectToAction("GetCategoryList"); // ekleme işlemi tamamlandıktan sonra buna getir.
        }
    }
}
