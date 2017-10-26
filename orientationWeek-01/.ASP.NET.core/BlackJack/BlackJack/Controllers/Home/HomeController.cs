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
        User user;
        Opponent dealer;
        List<Player> players;

        public HomeController(Deck deck, User user, Opponent dealer, List<Player> players)
        {
            this.deck = deck;
            this.user = user;
            this.dealer = dealer;
            this.players = players;
        }

        [HttpGet]
        public IActionResult Index()
        {
            dealer.Deal(deck);
            user.Deal(deck);
            players.Add(dealer);
            players.Add(user);
            return View(players);
        }
    }
}
