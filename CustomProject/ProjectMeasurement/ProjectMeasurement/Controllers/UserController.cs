using Microsoft.AspNetCore.Mvc;
using ProjectMeasurement.Services;
using System.Net;

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
        public IActionResult Login(string emailAddress, string projectName)
        {
            if (UserService.AuthenticateUser(emailAddress))
            {
                return LocalRedirect("/user/" + emailAddress + "/" + projectName);
            }
            return LocalRedirect("/user/login");
        }

        [Route("/user/{emailAddress}/{projectName}")]
        [HttpGet]
        public IActionResult UserPage(string emailAddress, string projectName)
        {
            string[] info = new string[2] { emailAddress, projectName };
            return View(info);
        }

        [Route("/user/{emailAddress}/newtask")]
        [HttpGet]
        public IActionResult NewTask(string emailAddress)
        {
            return View();
        }

        [Route("/user/{emailAddress}/addnewtask")]
        [HttpGet]
        public IActionResult AddNewTask(string taskName, string projectName)
        {
            UserService.AddNewTask(taskName, projectName);
            return RedirectToAction("UserPage");
        }
    }
}
