using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ProjectMeasurement.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
