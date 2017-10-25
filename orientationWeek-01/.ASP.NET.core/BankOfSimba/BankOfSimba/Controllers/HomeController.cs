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
            var homeViewModel = new HomeViewModel();

            for (int i = 0; i < homeViewModel.bankAccount.Count(); i++)
            {
                if (name == homeViewModel.bankAccount[i].Name)
                {
                    homeViewModel.bankAccount[i].Balance += 10;
                }
            }
            return View(homeViewModel);
        }
    }
}
