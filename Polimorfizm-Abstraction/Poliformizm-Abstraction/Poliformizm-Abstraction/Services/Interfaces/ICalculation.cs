using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformizm_Abstraction.Services.Interfaces
{
    internal interface ICalculation
    {
        string Calculate(double num1, double num2, string operation);
    }
}
