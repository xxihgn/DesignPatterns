using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Design_Pattern
{
    public class Shape(string name) : IComparable<Shape>
    {
        public override string ToString() => name;

        // IComparable<Shape> Member
        public int CompareTo(Shape? other) => (this == other) ? 0 : -1;
    }
}
