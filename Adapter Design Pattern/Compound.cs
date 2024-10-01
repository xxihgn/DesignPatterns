using Adapter.NetOptimized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern
{
    public class Compound
    {
        public Chemical Chemical { get; protected set; }
        public float BoilingPoint { get; protected set; }
        public float MeltingPoint { get; protected set; }
        public double MolecularWeight { get; protected set; }
        public string? MolecularFormula { get; protected set; }

        public virtual void Display()
        {
            Console.WriteLine("\nCompound: Unknown ------ ");
        }
    }
}
