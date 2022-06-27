using Microsoft.AspNetCore.Mvc;

namespace MVCProjeKamp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
