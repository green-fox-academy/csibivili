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

namespace PandaScore.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        private static string Token = "9ZHfjVV7sr-pIX6aNfq6TiwiGU-MZn8cMykYVh4elOvxTQrmdBM";

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            string result = await client.GetStringAsync("https://api.pandascore.co/leagues");
            var json = JsonConvert.DeserializeObject<List<League>>(result);
            return Json(json);
        }
    }
}
