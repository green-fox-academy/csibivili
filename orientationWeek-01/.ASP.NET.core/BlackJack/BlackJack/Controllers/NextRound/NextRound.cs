using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlackJack.Model;
using Microsoft.AspNetCore.Http;

namespace BlackJack.Controllers.Home
{
    [Route("/NextRound")]
    public class NextRound : Controller
    {
        Step WhichStep;

        [HttpPost]
        public IActionResult Step(IFormCollection formCollection)
        {
            string step = formCollection["pull"].ToString();
            ViewData.Add("peti", step);
            return View();
        }
    }
}
