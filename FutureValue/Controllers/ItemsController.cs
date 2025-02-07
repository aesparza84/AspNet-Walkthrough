using FutureValue.Models;
using Microsoft.AspNetCore.Mvc;

namespace FutureValue.Controllers
{
    public class ItemsController : Controller
    {
        /*
        We have 2 different views under 'Items'
        The way we display views is by having a method that matches the name
        of the requested view.
        With overloading, we can update a view, like the Future Value calculations.
        */

        [HttpGet]
        public IActionResult Details()
        {
            ViewBag.DET = 34;
            return View();
        }

        [HttpGet]
        public IActionResult Policy()
        {
            return View();
        }
    }
}
