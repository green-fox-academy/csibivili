using Microsoft.AspNetCore.Mvc;
using ProjectMeasurement.Services;

namespace ProjectMeasurement.Controllers
{
    public class AdminController : Controller
    {
        private UserService UserService;

        public AdminController(UserService userService)
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

        [Route("/deleteuser")]
        public IActionResult DeleteUser(string emailAddress)
        {
            UserService.DeleteUser(emailAddress);
            return LocalRedirect("/");
        }
    }
}
