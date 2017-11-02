using Microsoft.AspNetCore.Mvc;

namespace ToDoWebApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
