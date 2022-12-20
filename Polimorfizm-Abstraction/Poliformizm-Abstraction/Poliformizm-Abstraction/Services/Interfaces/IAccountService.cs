using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformizm_Abstraction.Services.Interfaces
{
    internal interface IAccountService
    {
        void Login(string username, string password);   
    }
}
