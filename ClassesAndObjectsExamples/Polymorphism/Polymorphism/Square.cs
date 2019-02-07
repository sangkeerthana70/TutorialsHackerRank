using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Square:Shape
    {
        int side;

        public Square(int s)
        {
            this.side = s;
        }

        public override int Area()
        {
            return side * side; 
        }
    }
}
