using Algorithms.Areas.Exercises.Models;
using Microsoft.AspNetCore.Mvc;

namespace Algorithms.Areas.Exercises.Controllers
{
    [Area("Exercises")]
    public class AngularTestController : Controller
    {
        public IActionResult Index() {
            ViewBag.Message = "Howdy";
            Employee e = new Employee() { FirstName = "John", LastName = "Doe" };

            return View(e);
        }

        public IActionResult UpdateData(string p1) {
            var updatedData = p1 + "--update sucessful--";
            var response = new Employee() { FirstName = "Jane", LastName = "Doe", Extra = updatedData };

            ViewBag.myTest = response;
            return Json(response);

        }
    }
}