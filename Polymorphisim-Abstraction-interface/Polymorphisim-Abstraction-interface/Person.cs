using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisim_Abstraction_interface
{
    internal class Person : IPerson
    {
        public void GetName()
        {
            Console.WriteLine("Cavid");

        }
    }
}
