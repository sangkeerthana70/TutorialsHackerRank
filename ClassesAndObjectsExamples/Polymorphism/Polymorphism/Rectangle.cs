using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Rectangle: Shape
    {

        int length;
        int width;

        public Rectangle(int l, int w)
        {
            this.length = l;
            this.width = w;
        }

        public override int Area()
        {
            return length * width;
        }

    }
}
