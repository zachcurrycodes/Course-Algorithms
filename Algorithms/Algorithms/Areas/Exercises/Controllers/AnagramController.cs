using Algorithms.Areas.Exercises.Models;
using Microsoft.AspNetCore.Mvc;

namespace Algorithms.Areas.Exercises.Controllers
{
    [Area("Exercises")]
    public class AnagramController : Controller
    {
        public IActionResult Index() {
            ViewData["Message"] = "Let's try to find an anagram";
            return View();
        }

        [HttpGet]
        public IActionResult Calculate2() {
            Anagram a = new Anagram(
                first: "test",
                second: "test"
            );

            var response = a.ValidAnagram();
            return Json(response);
        }

        [HttpGet]
        public IActionResult Calculate(string text1, string text2) {
            Anagram a = new Anagram(
                first: text1,
                second: text2
            );

            var response = a.ValidAnagram();
            return Json(response);
        }
    }
}
