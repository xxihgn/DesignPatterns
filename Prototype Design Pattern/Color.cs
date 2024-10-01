using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Prototype_Design_Pattern
{
    public class Color : ICloneableObject
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

        // Returns a shallow or a deep copy
        public object? Clone(bool shallow)
        {
            return shallow ? Clone() : DeepCopy();
        }

        // Creates a shallow copy
        public object Clone()
        {
            Console.WriteLine(
                "Shallow copy of color RGB: {0,3},{1,3},{2,3}",
                Red, Green, Blue);

            return MemberwiseClone();
        }

        // Creates a deep copy
        public object? DeepCopy()
        {
            // use serialized to create a deep copy
            var serialized = JsonSerializer.Serialize(this);
            var copy = JsonSerializer.Deserialize<Color>(serialized);

            if (copy is not null)
            {
                Console.WriteLine(
                    "*Deep* copy of color RGB: {0,3},{1,3},{2,3}",
                    (copy as Color).Red, (copy as Color).Green, (copy as Color).Blue
                );
            }

            return copy;
        }
    }
}
