using Microsoft.AspNetCore.Mvc;
using Anagramm.Model;
using System.Collections.Generic;

namespace Anagramm.Controllers.Home
{
    public class HomeController : Controller
    {
        Word word;
        List<Word> wordsList;

        public HomeController(Word word, List<Word> wordsList)
        {
            this.word = word;
            this.wordsList = wordsList;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Word word)
        {
            wordsList.Add(word);
            return RedirectToAction("result", word);
        }

        [HttpGet]
        [Route("result")]
        public IActionResult Result(Word word)
        {
            return View(word);
        }
    }
}
