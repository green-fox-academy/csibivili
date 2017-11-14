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
            return View(UserService.UserInfo(emailAddress));
        }

        [Route("/user/{emailAddress}/newtask")]
        [HttpGet]
        public IActionResult NewTask(string emailAddress)
        {
            return View();
        }

        [Route("/user/{emailAddress}/addnewtask")]
        [HttpGet]
        public IActionResult AddNewTask(string taskName, string emailAddress)
        {
            UserService.AddNewTask(taskName, UserService.UserInfo(emailAddress).Project.ProjectName);
            return RedirectToAction("UserPage");
        }
    }
}
