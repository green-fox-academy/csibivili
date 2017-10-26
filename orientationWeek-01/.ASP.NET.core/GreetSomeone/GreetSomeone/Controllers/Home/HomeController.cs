using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetSomeone.Model;

namespace GreetSomeone.Controllers.Home
{
    public class HomeController : Controller
    {
        Person person;

        public HomeController(Person person)
        {
            this.person = person;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person person)
        {
            return RedirectToAction("greet", person);
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult Greet(Person person)
        {
            return View(person);
        }
    }
}
