using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlackJack.Model;

namespace BlackJack.Controllers.Home
{
    public class HomeController : Controller
    {
        Deck deck;

        public HomeController(Deck deck)
        {
            this.deck = deck;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
