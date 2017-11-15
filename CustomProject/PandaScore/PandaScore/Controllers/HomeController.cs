using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PandaScore.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

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
            var teams = JsonConvert.DeserializeObject<List<Team>>(result);
            return Json(teams);
        }
        
        [HttpGet]
        [Route("/tournaments")]
        public async Task<IActionResult> Tournaments()
        {
            string result = await Client.GetStringAsync(url + "tournaments");
            var tournaments = JsonConvert.DeserializeObject<List<Tournament>>(result);
            return Json(tournaments);
        }

        [HttpGet]
        [Route("/matches")]
        public async Task<IActionResult> Matches()
        {
            string result = await Client.GetStringAsync(url + "matches");
            var matches = JsonConvert.DeserializeObject<List<Match>>(result);
            return Json(matches);
        }
    }
}
