using Abstract.NetOptimized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public interface IContinentFactory
    {
        IHerbivore CreateHerbivore();
        ICarnivore CreateCarnivore();
    }
}
