using System;
using Microsoft.AspNetCore.Mvc;
using challenge.Models;

namespace challenge.Controllers
{
    public class TestController : Controller
    {
        [Route("test")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("test/display")]
        public IActionResult DisplayTest(string name, string text)
        {
            TestModel test = new TestModel{
                Name = name,
                Text = text
            };

            return View(test);
        }
    }
}