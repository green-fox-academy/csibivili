using Microsoft.AspNetCore.Mvc;
using ProjectMeasurement.Services;

namespace ProjectMeasurement.Controllers
{
    public class AdminController : Controller
    {
        private UserService UserService;
        private ProjectService ProjectService;

        public AdminController(UserService userService)
        {
            UserService = userService;
        }

        public AdminController(ProjectService projectService)
        {
            ProjectService = projectService;
        }

        [Route("/adduser")]
        [HttpPost]
        public IActionResult AddUser(string emailAddress)
        {
            UserService.AddNewUser(emailAddress);
            return Ok();
        }

        [Route("/deleteuser")]
        [HttpDelete]
        public IActionResult DeleteUser(string emailAddress)
        {
            UserService.DeleteUser(emailAddress);
            return Ok();
        }

        [Route("/addproject")]
        [HttpPost]
        public IActionResult AddProject(string projectName)
        {
            ProjectService.AddProject(projectName);
            return Ok();
        }
    }
}
