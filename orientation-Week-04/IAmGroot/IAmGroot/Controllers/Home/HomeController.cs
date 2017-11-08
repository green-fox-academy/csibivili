using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IAmGroot.Models;

namespace IAmGroot.Controllers.Home
{
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/groot")]
        public IActionResult Groot(string message)
        {
            if (message == null)
            {
                var notfound = new NotFoundObjectResult(new { message = "404 Not Found", error = "I am Groot!" });
                return notfound;
            }
            else
            {
                return Json(new { received = message, translated = "I am Groot!" });
            }
        }

        [HttpGet]
        [Route("/yondu")]
        public IActionResult Yondu(double distance, double time)
        {
            var yondu = new Yondu() { Distance = distance, Time = time, Speed=distance/time };
            return Json(yondu);
        }
    }
}
