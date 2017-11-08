using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IAmGroot.Controllers.Home
{
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/groot")]
        public IActionResult Groot(string message)
        {
            return Json(new { received = message, translated = "I am Groot!" });
        }
    }
}
