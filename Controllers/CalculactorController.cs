using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using WebCalulatorMvc.Models;

namespace WebCalulatorMvc.Controllers
{
    public class CalculactorController : Controller
    {
        private readonly AppDbContext _context;
        public CalculactorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(double? result)
        {
            var history = _context.History.OrderByDescending(h => h.Date).ToList();
            ViewBag.Result = result;
            ViewBag.Error = TempData["Error"];
            return View();
        }
        [HttpPost]
        public IActionResult Add(double num1,double num2)
        {
            double result = num1 + num2;

            _context.History.Add(new CalculationHistory
            {
                Expression = $"{num1} + {num2}",
                Result = result,
                Date = DateTime.Now
            });
            _context.SaveChanges();

            return RedirectToAction("Index", new { result });
        }
        [HttpPost]
        public IActionResult Sqrt(double num1)
        {
            if (num1 < 0)
            {
                TempData["Error"] = "Nie pierwiastkować liczb ujemnych!";
                return RedirectToAction("Index");
            }
            double result = Math.Sqrt(num1);
            
            _context.History.Add(new CalculationHistory
            {
                Expression = $"{num1}",
                Result = result,
                Date = DateTime.Now
            });
            _context.SaveChanges();

            return RedirectToAction("Index", new { result });
        }
        [HttpPost]
        public IActionResult Pow(double num1, double num2)
        {
            double result = Math.Pow(num1,num2);

            _context.History.Add(new CalculationHistory
            {
                Expression = $"{num1} + {num2}",
                Result = result,
                Date = DateTime.Now
            });
            _context.SaveChanges();

            return RedirectToAction("Index", new { result });
        }
        [HttpPost]
        public IActionResult Divided(double num1, double num2)
        {
            if (num2 == 0)
            {
                TempData["Error"] = "Nie można dzielić przez zero!";
                return RedirectToAction("Index");
            }
            double result = num1 / num2;

            _context.History.Add(new CalculationHistory
            {
                Expression = $"{num1} + {num2}",
                Result = result,
                Date = DateTime.Now
            });
            _context.SaveChanges();

            return RedirectToAction("Index", new { result });
        }
        [HttpPost]
        public IActionResult Modulo(double num1, double num2)
        {
            if (num2 == 0)
            {
                TempData["Error"] = "Nie można dzielić przez zero!";
                return RedirectToAction("Index");
            }
            double result = num1 % num2;

            _context.History.Add(new CalculationHistory
            {
                Expression = $"{num1} + {num2}",
                Result = result,
                Date = DateTime.Now
            });
            _context.SaveChanges();

            return RedirectToAction("Index", new { result });
        }
        [HttpPost]
        public IActionResult subtraction(double num1, double num2)
        {
            
            double result = num1 - num2;

            _context.History.Add(new CalculationHistory
            {
                Expression = $"{num1} + {num2}",
                Result = result,
                Date = DateTime.Now
            });
            _context.SaveChanges();

            return RedirectToAction("Index", new { result });
        }

    }
}
