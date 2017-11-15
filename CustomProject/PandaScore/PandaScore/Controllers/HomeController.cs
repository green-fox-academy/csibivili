using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using PandaScore.Models;
using Microsoft.EntityFrameworkCore;

namespace PandaScore.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        private static readonly string Token = "9ZHfjVV7sr-pIX6aNfq6TiwiGU-MZn8cMykYVh4elOvxTQrmdBM";
        private static readonly string url = "https://api.pandascore.co/";
        private readonly HttpClient Client;

        public HomeController()
        {
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
        }

        [HttpGet]
        [Route("/leagues")]
        public async Task<IActionResult> Leagues()
        {
            string result = await Client.GetStringAsync(url + "leagues");
            var leagues = JsonConvert.DeserializeObject<List<League>>(result);
            return Json(leagues);
        }

        [HttpGet]
        [Route("/players")]
        public async Task<IActionResult> Players()
        {
            string result = await Client.GetStringAsync(url + "players");
            var players = JsonConvert.DeserializeObject<List<Player>>(result);
            return Json(players);
        }

        [HttpGet]
        [Route("/teams")]
        public async Task<IActionResult> Teams()
        {
            string result = await Client.GetStringAsync(url + "teams");
            return Content(result);
        }

        [HttpGet]
        [Route("/tournaments")]
        public async Task<IActionResult> Tournaments()
        {
            string result = await Client.GetStringAsync(url + "tournaments");
            return Content(result);
        }
    }
}
