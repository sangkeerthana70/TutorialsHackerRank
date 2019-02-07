using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance
            Shape shape = new Shape();
            Console.WriteLine(shape.Area());// returns 0 as it invokes the Area method inside the shape class

            Rectangle rectangle = new Rectangle(15, 5);
            Console.WriteLine(rectangle.Area());// returns 0 Even though rectangle does not have a method called area, it works because it inherited the method from the base class Shape. This is inheritence

            // Method override at work
            Shape x = new Shape();
            Console.WriteLine(x.Area());

            Square square = new Square(10);
            Console.WriteLine(square.Area());// returns 100 Square's area method is invoked, override at work

        }
    }
}
