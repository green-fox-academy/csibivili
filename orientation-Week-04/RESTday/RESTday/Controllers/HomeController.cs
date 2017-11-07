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
            var result = new Doubling();
            result.received = input;
            result.result = input * 2;
            return Json(result);
        }
    }
}
