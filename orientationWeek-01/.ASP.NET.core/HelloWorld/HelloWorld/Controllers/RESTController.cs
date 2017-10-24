using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorld.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public ContentResult Greeting(string name)
        {
            Startup.numberOfApiCalls++;

            string result = String.Format("Hello, {0}! This site was loaded {1} times since last server start.", name, Startup.numberOfApiCalls);

            return Content(result);
        }
    }
}
