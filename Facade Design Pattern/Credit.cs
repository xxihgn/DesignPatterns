using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Facade.NetOptimized.Program;

namespace Facade_Design_Pattern
{
    public class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine($"Check credit for {c.Name}");
            return true;
        }
    }
}
