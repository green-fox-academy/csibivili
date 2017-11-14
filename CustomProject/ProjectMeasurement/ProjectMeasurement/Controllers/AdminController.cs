using Microsoft.AspNetCore.Mvc;
using ProjectMeasurement.Services;
using Newtonsoft.Json;

namespace ProjectMeasurement.Controllers
{
    [Route("/admin")]
    public class AdminController : Controller
    {
        private UserService UserService;
        private ProjectService ProjectService;

        public AdminController(UserService userService, ProjectService projectService)
        {
            UserService = userService;
            ProjectService = projectService;
        }

        [Route("/adduser")]
        [HttpGet]
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

        [Route("/deleteproject")]
        [HttpPost]
        public IActionResult DeleteProject(string projectName)
        {
            ProjectService.DeleteProject(projectName);
            return Ok();
        }

        [Route("/assignuser")]
        [HttpPut]
        public IActionResult AssignUser(string emailAddress, string projectName)
        {
            UserService.AssignUser(emailAddress, projectName);
            return Ok();
        }
    }
}
