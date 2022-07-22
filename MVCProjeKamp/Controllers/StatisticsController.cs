using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MVCProjeKamp.Controllers
{
    public class StatisticsController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var categoryCount = _context.Categories.Count().ToString();
            ViewBag.CategoryCount = categoryCount;
            var softwareHeadings = _context.Headings.Where(h=>h.Category.CategoryName == "Yazılım").Count().ToString();
            ViewBag.SoftwareHeadings = softwareHeadings;
            var writerCountA = _context.Writers.Where(w=> w.WriterName.Contains("a") || w.WriterName.Contains("A")).Count().ToString();
            ViewBag.WriterCountA = writerCountA;
            var maxHeadingCategory = _context.Headings.Max(h => h.Category.CategoryName);
            ViewBag.MaxHeadingCategory = maxHeadingCategory;    
            var trueCategories = _context.Categories.Where(c => c.CategoryStatus == true).Count();
            var falseCategories = _context.Categories.Where(c => c.CategoryStatus == false).Count();
            ViewBag.CategoryDifference = (trueCategories - falseCategories).ToString();
            return View();
        }

        
    }
}
