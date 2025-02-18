using Microsoft.AspNetCore.Mvc;

namespace FutureValue.Controllers
{
    public class TestController : Controller
    {

        [HttpGet]
        public IActionResult TestView()
        {
            ViewBag.email = "";
            return View();
        }

        [HttpPost]
        public IActionResult Login()
        {
            return View();
        }
    }
}
