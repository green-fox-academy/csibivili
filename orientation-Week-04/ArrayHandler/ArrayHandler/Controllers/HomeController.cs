using ArrayHandler.Collections;
using ArrayHandler.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArrayHandler.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpPost]
        [Route("/arrays")]
        public IActionResult Arrays([FromBody]OperationOnNumbers operationOnNumbers)
        {
            Operations.OperationTypes
                .Find(operation => operation.WhatOperation == operationOnNumbers.What)
                .Result = operationOnNumbers.Numbers;

            object result = Operations.OperationTypes
                .Find(operation => operation.WhatOperation == operationOnNumbers.What)
                .Result;

            return Json(new { result = result });
        }
    }
}
