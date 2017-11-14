using Microsoft.AspNetCore.Mvc;

namespace ProjectMeasurement.Controllers
{
    [Route("/userlogin")]
    public class UserLoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
