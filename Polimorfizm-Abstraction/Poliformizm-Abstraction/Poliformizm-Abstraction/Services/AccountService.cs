using Poliformizm_Abstraction.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformizm_Abstraction.Services
{
    internal class AccountService : IAccountService
    {
        public void Login(string username, string password)
        {
            if (username == "Konul123" && password == "Konul1996")
            {
                Console.WriteLine("Girish ugurludur");
            }
            else
            {
                Console.WriteLine("Username ve ya password sehvdir");
            }
        }
    }
}
