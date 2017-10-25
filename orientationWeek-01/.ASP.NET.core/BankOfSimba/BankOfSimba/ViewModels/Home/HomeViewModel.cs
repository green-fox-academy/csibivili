using BankOfSimba.Models;
using System.Collections.Generic;

namespace BankOfSimba.ViewModels.Home
{
    public class HomeViewModel
    {
        public List<BankAccount> bankAccount;
        public HomeViewModel()
        {
            bankAccount = new List<BankAccount>();
        }
    }
}
