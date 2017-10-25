using BankOfSimba.Models;
using BankOfSimba.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index(string name)
        {
            //var homeViewModel = new HomeViewModel();

            for (int i = 0; i < Startup.homeViewModel.bankAccount.Count(); i++)
            {
                if (name == Startup.homeViewModel.bankAccount[i].Name)
                {
                    if (name == "Mufasa")
                    {
                        Startup.homeViewModel.bankAccount[i].Balance += 90;
                    }
                    Startup.homeViewModel.bankAccount[i].Balance += 10;
                }
            }
            return View(Startup.homeViewModel);
        }
    }
}
