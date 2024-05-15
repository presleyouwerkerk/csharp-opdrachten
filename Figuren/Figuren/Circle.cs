using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren
{
    internal class Circle : Figure
    {
        private int length;

        public Circle(string color, int length): base(color)
        {
            this.length = length;
        }

        public override string Draw()
        {
            return "Dit is een cirkel met de kleur " + getColor() + " en de diameter " + length;
        }
    }
}
