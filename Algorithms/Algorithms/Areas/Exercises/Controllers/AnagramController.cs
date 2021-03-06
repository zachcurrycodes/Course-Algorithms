﻿using Algorithms.Areas.Exercises.Models;
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

        [HttpPost]
        public IActionResult Calculate([FromBody] Anagram ab) {
            string response;
            if (ab.first == null || ab.second == null) {
                response = "Atleast one word is null";
            } else {
                Anagram a = new Anagram(
                    first: ab.first,
                    second: ab.second
                );
                response = a.ValidAnagram();
            }
            return Json(response);
        }
    }
}
