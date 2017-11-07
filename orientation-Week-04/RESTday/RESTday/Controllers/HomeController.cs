using Microsoft.AspNetCore.Mvc;
using RESTday.Excercises;
using RESTday.Collections;

namespace RESTday.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new {error= "Please provide an input!" });
            }
            else
            {
                return Json(new Doubling() { received = (int)input, result = (int)input * 2 });
            }
        }

        [HttpGet]
        [Route("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null || title == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new Greeter() { Name=name, Title=title}.Greeting());
            }
        }

        [HttpGet]
        [Route("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            if (appendable == null)
            {
                return NotFound();
            }
            return Json(new Append() { Appended=appendable});
        }

        [HttpPost]
        [Route("/dountil/{what}")]
        public IActionResult DoUntil(string what, [FromBody]UntilWhat until)
        {
            if (Operations.OperationTypes.Exists(operation => operation.WhatKindOfEvent == what))
            {
                if (until != null)
                {
                    Operations.OperationTypes.Find(operation => operation.WhatKindOfEvent == what).Result = until.Until;
                    int result = Operations.OperationTypes.Find(operation => operation.WhatKindOfEvent == what).Result;
                    return Json(new { result = result });
                }
                else
                {
                    return Json(new { error = "Please provide a number!" });
                }
            }
            else
            {
                return NotFound();
            }
        }
    }
}
