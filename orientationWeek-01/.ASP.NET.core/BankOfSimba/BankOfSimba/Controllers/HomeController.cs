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
            for (int i = 0; i < Program.homeViewModel.bankAccount.Count(); i++)
            {
                if (name == Program.homeViewModel.bankAccount[i].Name)
                {
                    if (name == "Mufasa")
                    {
                        Program.homeViewModel.bankAccount[i].Balance += 90;
                    }
                    Program.homeViewModel.bankAccount[i].Balance += 10;
                }
            }
            return View(Program.homeViewModel);
        }
    }
}
