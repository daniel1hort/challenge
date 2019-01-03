using System;
using Microsoft.AspNetCore.Mvc;
using challenge.Models;

namespace challenge.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index(string name, string text)
        {
            TestModel test;

            if(!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(text))
            {
                test = new TestModel{
                    Name = name,
                    Text = text
                };
            }
            else
                test = null;

            return View(test);
        }
    }
}