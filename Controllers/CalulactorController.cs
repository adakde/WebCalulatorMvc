using Microsoft.AspNetCore.Mvc;

namespace WebCalulatorMvc.Controllers
{
    public class CalulactorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(double num1,double num2)
        {
            double result = num1 + num2;
            return RedirectToAction("Index", new { result });
        }
        [HttpPost]
        public IActionResult Sqrt(double num1)
        {
            double result = Math.Sqrt(num1);
            return RedirectToAction("Index", new { result });
        }
        [HttpPost]
        public IActionResult Pow(double num1, double num2)
        {
            double result = Math.Pow(num1,num2);
            return RedirectToAction("Index", new { result });
        }
        [HttpPost]
        public IActionResult Divided(double num1, double num2)
        {

            double result = num1 / num2;
            return RedirectToAction("Index", new { result });
        }
        [HttpPost]
        public IActionResult Modulo(double num1, double num2)
        {
            double result = num1 % num2;
            return RedirectToAction("Index", new { result });
        }
        [HttpPost]
        public IActionResult subtraction(double num1, double num2)
        {
            double result = num1 - num2;
            return RedirectToAction("Index", new { result });
        }

    }
}
