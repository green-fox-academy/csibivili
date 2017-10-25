using BankOfSimba.Models;
using System.Collections.Generic;

namespace BankOfSimba.ViewModels.Home
{
    public class HomeViewModel
    {
        public List<BankAccount> bankAccount;
        public HomeViewModel()
        {
            bankAccount = Fill();
        }

        public List<BankAccount> Fill()
        {
            List<BankAccount> temp = new List<BankAccount>();
            temp.Add(new Models.BankAccount
            { Name = "Simba", Balance = 2000.00, AnimalType = Models.TypeOfAnimal.Lion });
            temp.Add(new Models.BankAccount
            { Name = "Mufasa", Balance = 3000000.00, AnimalType = Models.TypeOfAnimal.Lion, isKing = true });
            temp.Add(new Models.BankAccount
            { Name = "Rafiki", Balance = 20.00, AnimalType = Models.TypeOfAnimal.Monkey });
            temp.Add(new Models.BankAccount
            { Name = "Zordon", Balance = -2000000.00, AnimalType = Models.TypeOfAnimal.Lion, isGood = false });
            temp.Add(new Models.BankAccount
            { Name = "Zazu", Balance = -20000.00, AnimalType = Models.TypeOfAnimal.Parrot });
            return temp;
        }
    }
}
