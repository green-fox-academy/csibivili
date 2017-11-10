using Microsoft.AspNetCore.Mvc;
using ToDoWebApp.Services;

namespace ToDoWebApp.Controllers.Login
{
    [Route("/login")]
    public class LoginController : Controller
    {
        UserService UserService;

        public LoginController(UserService userService)
        {
            UserService = userService;
        }

        [HttpPost]
        public IActionResult Login(string userName)
        {
            if (!UserService.AuthenticateUser(userName))
            {
                UserService.AddUser(userName);             
            }

            int id = (int)UserService.UserInfo(userName).UserId;

            return LocalRedirect("/todo/" + id + "/list");
        }
    }
}
