using Prototype.NetOptimized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Design_Pattern
{
    public record ColorManager
    {
        private readonly Dictionary<ColorType, Color> colors = [];

        // Gets or sets color
        public Color this[ColorType type]
        {
            get => colors[type];
            set => colors.Add(type, value);
        }
    }
}
