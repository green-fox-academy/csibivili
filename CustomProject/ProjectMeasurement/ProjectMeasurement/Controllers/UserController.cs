using Microsoft.AspNetCore.Mvc;
using ProjectMeasurement.Services;

namespace ProjectMeasurement.Controllers
{
    [Route("/user")]
    public class UserController : Controller
    {
        private UserService UserService;

        public UserController(UserService userService)
        {
            UserService = userService;
        }

        [HttpPost]
        public IActionResult Login(string emailAddress)
        {
            if (UserService.AuthenticateUser(emailAddress))
            {
                return LocalRedirect("/user/" + emailAddress);
            }
            return LocalRedirect("/user/login");
        }

        [Route("/user/{emailAddress}")]
        [HttpGet]
        public IActionResult UserPage(string emailAddress)
        {
            return View();
        }
    }
}
