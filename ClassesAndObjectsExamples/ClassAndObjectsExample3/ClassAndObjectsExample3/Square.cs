using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectsExample3
{
    public class Square
    {
        public int side;

        public Square(int s){
            this.side = s;
        }

        public int Area()
        {
            int area = side * side;
            //Console.WriteLine(area);
            return area;
        }

        public int Perimeter()
        {
            int perimeter = side * 4;
            //Console.WriteLine(perimeter);
            return perimeter;
        }

        public void About()
        {
            Console.Write("I am a square with a side of " + this.side);
            Console.Write(" With an area of : " + this.Area());
            Console.Write(" And a perimeter of : " + this.Perimeter());
            Console.WriteLine();

        }
    }
}
