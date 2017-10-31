using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToDoWebApp.Controllers
{
    [Route("/Todo")]
    public class TodoController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult List()
        {
            string tmp = "This is my first todo";
            return View((object)tmp);
        }
    }
}
