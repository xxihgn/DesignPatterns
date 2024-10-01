using Abstract.NetOptimized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class America : IContinentFactory
    {
        public IHerbivore CreateHerbivore() => new Bison();

        public ICarnivore CreateCarnivore() => new Wolf();
    }
    
}
