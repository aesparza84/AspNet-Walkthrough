using FutureValue.Models;
using Microsoft.AspNetCore.Mvc;

namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        //Any HTTP POST/GET is an 'Action' method 
        
        [HttpGet] //Mark this method as a GET
        public IActionResult Index()
        {

            /*
            ViewBag.Name = "Mary"; //We created the property 'Name' and set it in this line
                                   //Because ViewBag is a 'dynamic' value
            
            ViewBag.FV = 31; //Same here like above

            ViewBag.Age = 33;
            */

            ViewBag.FV = 0; //Future Value btw

            //View() is an IAction so we can return it
            return View();
        }        

        [HttpPost] //Mark this method as POST
        public IActionResult Index(FutureValueModel model)
        {
            //The model holds all the calculating logic.
            //We just store the result here to return it.

            //Validates the model
            if(ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateFutureValue();
            }
            else
            {
                ViewBag.FV = 0;
            }



            return View(model);
        }
    }
}
