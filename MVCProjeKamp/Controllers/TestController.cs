using Microsoft.AspNetCore.Mvc;

namespace MVCProjeKamp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Test2()
        {
            return View();
        }
    }
}
