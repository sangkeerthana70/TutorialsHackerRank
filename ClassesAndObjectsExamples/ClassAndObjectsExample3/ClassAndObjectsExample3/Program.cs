using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectsExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(8);
            //square1.Area(8);
            //square1.Perimeter(8);
            Square square2 = new Square(12);
            Square square3 = new Square(4);

            List <Square> squares = new List <Square> ();
            squares.Add(square1);
            squares.Add(square2);
            squares.Add(square3);
            foreach(Square item in squares)
            {
                item.About();
            }
        }
    }
}
