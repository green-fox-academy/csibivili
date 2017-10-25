﻿using BankOfSimba.Models;
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

            homeViewModel.bankAccount.Add(new Models.BankAccount
            { Name = "Simba", Balance = 2000.00, AnimalType = Models.TypeOfAnimal.Lion });
            homeViewModel.bankAccount.Add(new Models.BankAccount
            { Name = "Mufasa", Balance = 3000000.00, AnimalType = Models.TypeOfAnimal.Lion, isKing = true });
            homeViewModel.bankAccount.Add(new Models.BankAccount
            { Name = "Rafiki", Balance = 20.00, AnimalType = Models.TypeOfAnimal.Monkey });
            homeViewModel.bankAccount.Add(new Models.BankAccount
            { Name = "Zordon", Balance = -2000000.00, AnimalType = Models.TypeOfAnimal.Lion, isGood = false });
            homeViewModel.bankAccount.Add(new Models.BankAccount
            { Name = "Zazu", Balance = -20000.00, AnimalType = Models.TypeOfAnimal.Parrot });

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
