using Abstract.NetOptimized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class Africa : IContinentFactory
    {

        public IHerbivore CreateHerbivore() => new Wildebeest();

        public ICarnivore CreateCarnivore() => new Lion();

    }
}
