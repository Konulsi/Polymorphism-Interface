using Polymorphisim_Abstraction_interface.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisim_Abstraction_interface.Services
{
    internal class AccountService : IAccountService, ICommonService

    {
        public string FullData()
        {
            throw new NotImplementedException();
        }
    }
}
