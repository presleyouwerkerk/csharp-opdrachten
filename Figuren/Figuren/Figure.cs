using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren
{
    internal abstract class Figure
    {
        private string color;

        public Figure(string color)
        {
            this.color = color;
        }

        public string getColor() 
        {
            return color;
        }

        public abstract string Draw();
    }
}
