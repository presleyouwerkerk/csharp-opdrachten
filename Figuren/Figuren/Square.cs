using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren
{
    internal class Square : Figure
    {
        private int length;

        public Square(string color, int length): base (color) 
        {
            this.length = length;
        }

        public override string Draw()
        {
            return "Dit is een vierkant met de kleur " + getColor() + " en de lengte " + length;
        }
    }
}
