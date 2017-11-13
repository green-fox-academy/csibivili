using Microsoft.AspNetCore.Mvc;
using ProjectMeasurement.Services;

namespace ProjectMeasurement.Controllers
{
    public class HomeController : Controller
    {
        private UserService UserService;

        public HomeController(UserService userService)
        {
            UserService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/adduser")]
        public IActionResult AddUser(string emailAddress)
        {
            UserService.AddNewUser(emailAddress);
            return LocalRedirect("/");
        }
    }
}
