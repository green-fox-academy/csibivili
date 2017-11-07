﻿using Microsoft.AspNetCore.Mvc;
using RESTday.Excercises;

namespace RESTday.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new {error= "Please provide an input!" });
            }
            else
            {
                return Json(new Doubling() { received = (int)input, result = (int)input * 2 });
            }
        }
    }
}
