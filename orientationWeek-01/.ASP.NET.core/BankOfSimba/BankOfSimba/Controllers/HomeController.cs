using BankOfSimba.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel();

            homeViewModel.bankAccount.Add(new Models.BankAccount
                { Name = "Simba", Balance = 2000.00, AnimalType = Models.TypeOfAnimal.Lion });
            homeViewModel.bankAccount.Add(new Models.BankAccount
                { Name = "Mufasa", Balance = 3000000.00, AnimalType = Models.TypeOfAnimal.Lion });
            homeViewModel.bankAccount.Add(new Models.BankAccount
                { Name = "Rafiki", Balance = 20.00, AnimalType = Models.TypeOfAnimal.Monkey });
            homeViewModel.bankAccount.Add(new Models.BankAccount
                { Name = "Zordon", Balance = -2000000.00, AnimalType = Models.TypeOfAnimal.Lion });
            homeViewModel.bankAccount.Add(new Models.BankAccount
                { Name = "Zazu", Balance = -20000.00, AnimalType = Models.TypeOfAnimal.Parrot });

            return View(homeViewModel);
        }
    }
}
