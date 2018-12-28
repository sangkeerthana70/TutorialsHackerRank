using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    class Square:Shape
    {
        private int side;
        // a static variable is global for all instances of a class hence it keep track of the number of squares for each instantiation of the Square class
        public static int numberOfSquares;

        public Square(int s) : base()
        {
            this.side = s;
            numberOfSquares++;
            //Console.WriteLine("Number of Squares = " + numberOfSquares);
        }

        private int Area()
        {
            int area = side * side;
            //Console.WriteLine(area);
            return area;
        }

        private int Perimeter()
        {
            int perimeter = side * 4;
            //Console.WriteLine(perimeter);
            return perimeter;
        }

        public override void About()
        {
            Console.Write("I am a square with a side of " + this.side);
            Console.Write(" With an area of : " + this.Area());
            Console.Write(" And a perimeter of : " + this.Perimeter());
            Console.WriteLine();          

        }

        public static void Definition()
        {
            Console.WriteLine("Square is a 2-D shape with four equal sides that meet at right angle");
        }
    }
}
