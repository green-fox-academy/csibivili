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
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/admin/adduser")]      
        public IActionResult AddUser(string emailAddress)
        {
            UserService.AddNewUser(emailAddress);
            return LocalRedirect("/admin");
        }

        [HttpPost]
        [Route("/admin/deleteuser")]
        public IActionResult DeleteUser(string emailAddress)
        {
            UserService.DeleteUser(emailAddress);
            return LocalRedirect("/admin");
        }
        
        [HttpPost]
        [Route("/admin/addproject")]
        public IActionResult AddProject(string projectName)
        {
            ProjectService.AddProject(projectName);
            return LocalRedirect("/admin");
        }

        [HttpPost]
        [Route("/admin/deleteproject")]
        public IActionResult DeleteProject(string projectName)
        {
            ProjectService.DeleteProject(projectName);
            return LocalRedirect("/admin");
        }

        [HttpPost]
        [Route("/admin/assignuser")]
        public IActionResult AssignUser(string emailAddress, string projectName)
        {
            UserService.AssignUser(emailAddress, projectName);
            return LocalRedirect("/admin");
        }

        [HttpPost]
        [Route("/admin/removeuserfromproject")]
        public IActionResult RemoveUserFromProject(string emailAddress, string projectName)
        {
            UserService.RemoveUserFromProject(emailAddress, projectName);
            return LocalRedirect("/admin");
        }
    }
}
