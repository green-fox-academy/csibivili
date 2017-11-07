using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Doubling(int input)
        {
            return Json(new Doubling() { received = input, result = input * 2 });
        }
    }
}
