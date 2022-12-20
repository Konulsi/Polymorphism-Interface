using Poliformizm_Abstraction.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformizm_Abstraction.Services
{
    internal class Calculation : ICalculation
    {
        public string Calculate(double num1, double num2, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    return result.ToString();
                case "-":
                    result = num2 - num1;
                    return result.ToString();
                case "*":
                    result = num2 * num1;
                    return result.ToString();
                case "/":
                    result = num2 / num1;
                    return result.ToString();
                default:
                    return "Duzgun reqem daxil edin";

            }

        }
    }
}
