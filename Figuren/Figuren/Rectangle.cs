using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren
{
    internal class Rectangle : Figure
    {
        private int height;
        private int width;

        public Rectangle(string color, int height, int width): base (color)
        {
            this.height = height;
            this.width = width;
        }

        public override string Draw()
        {
            return "Dit is een rechthoek met de kleur " + getColor() + ", hoogte " + height + " en breedte " + width;
        }
    }
}
