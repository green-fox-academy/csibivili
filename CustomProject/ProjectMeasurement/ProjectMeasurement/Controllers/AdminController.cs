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

        [HttpGet]
        [Route("/adduser")]      
        public IActionResult AddUser(string emailAddress)
        {
            UserService.AddNewUser(emailAddress);
            return Ok();
        }

        [HttpDelete]
        [Route("/deleteuser")]
        public IActionResult DeleteUser(string emailAddress)
        {
            UserService.DeleteUser(emailAddress);
            return Ok();
        }
        
        [HttpPost]
        [Route("/addproject")]
        public IActionResult AddProject(string projectName)
        {
            ProjectService.AddProject(projectName);
            return Ok();
        }
        
        [HttpPost]
        [Route("/deleteproject")]
        public IActionResult DeleteProject(string projectName)
        {
            ProjectService.DeleteProject(projectName);
            return Ok();
        }
        
        [HttpPut]
        [Route("/assignuser")]
        public IActionResult AssignUser(string emailAddress, string projectName)
        {
            UserService.AssignUser(emailAddress, projectName);
            return Ok();
        }

        [HttpPut]
        [Route("/removeuserfromproject")]
        public IActionResult RemoveUserFromProject(string emailAddress, string projectName)
        {
            UserService.RemoveUserFromProject(emailAddress, projectName);
            return Ok();
        }
    }
}
