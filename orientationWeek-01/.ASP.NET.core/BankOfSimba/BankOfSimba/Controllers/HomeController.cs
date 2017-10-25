using BankOfSimba.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var homeViewModel = new HomeViewModel();
            return View("Index");
        }
    }
}
