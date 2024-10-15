using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Facade.NetOptimized.Program;

namespace Facade_Design_Pattern
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine($"Check bank for {c.Name}");
            return true;
        }
    }
}
