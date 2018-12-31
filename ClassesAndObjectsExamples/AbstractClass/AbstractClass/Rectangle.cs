using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Rectangle :Shape
    {
        private int Length;
        private int Width;
        // a static variable is global for all instances of a class hence it keep track of the numbber of rectangles for each instantiation of the rectangle class
        public static int numberOfRectangles;
        
        public Rectangle(int l, int w, string c) : base()
        {
            Length = l;
            Width = w;
            numberOfRectangles++;
            color = c;

            //Console.WriteLine("number of rectangles = " + numberOfRectangles);
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

        public override void About()
        {
            Console.Write("I am a rectangle with a length of " + Length);
            Console.Write(" And a width of " + Width);
            Console.Write(" My Perimeter is " + this.Perimeter());
            Console.Write(" My area is " + this.Area());
            Console.WriteLine(" I am " + this.color + " in color.");
            Console.WriteLine();
        }

        public static void Definition()
        {
            Console.WriteLine("A rectangle is 2-D with four sides that meet at right angle. The opposite sides will be equal in length");
        }

        // implement the ThreeDShape() method of the base class which is abstract
        public override string ThreeDShape()
        {
            return "Rectangular Prism";
        }

    }
}
