using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectsExample3
{
    public class Rectangle:Shapes
    {
        private int Length;
        private int Width;
        public Rectangle(int length, int width): base()
        {
            this.Length = length;
            this.Width = width;
        }

        private int Perimeter()
        {
            int perimeter = 2 * (Length + Width);
            return perimeter;
        }

        private int Area()
        {
            int area = Length * Width;
            return area;
        }

        public void About()
        {
            Console.Write("I am a rectangle with a length of " + Length );
            Console.Write(" And a width of " + Width);
            Console.Write(" My Perimeter is " + this.Perimeter());
            Console.Write(" My area is " + this.Area());
            Console.WriteLine();
        }


    }
}
