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
    public class NextRoundController : Controller
    {
        Deck deck;
        User user;
        Opponent dealer;
        List<Player> players;

        public NextRoundController(Deck deck, User user, Opponent dealer, List<Player> players)
        {
            this.deck = deck;
            this.user = user;
            this.dealer = dealer;
            this.players = players;
        }

        [HttpPost]
        public IActionResult Step(Step choice)
        {
            if (choice.WhichStep == "pull")
            {
                user.Pull(deck);
            }
            if (choice.WhichStep == "stop")
            {
            }
            return View(players);
        }
    }
}
