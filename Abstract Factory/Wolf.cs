using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class Wolf : ICarnivore
    {
        // Eat Bison
        public void Eat(IHerbivore h) =>
            Console.WriteLine($"{GetType().Name} eats {h.GetType().Name}");
    }
}
