using Microsoft.AspNetCore.Mvc;

namespace Algorithms.Controllers
{
    [Area("Anagram")]
    public class AnagramController : Controller
    {
        public IActionResult Index() {
            ViewData["Message"] = "Let's try to find an anagram";
            return View();
        }

        public IActionResult Calculate() {

            return View();
        }
    }
}
