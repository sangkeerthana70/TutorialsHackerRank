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

            // Method override at work - polymorphism
            Shape x = new Shape();
            Console.WriteLine(x.Area());

            Square square = new Square(10);
            Console.WriteLine(square.Area());// returns 100 Square's area method is invoked, override at work

            // Another example of polymorphism
            Shape z = new Rectangle(5, 2);
            Console.WriteLine(z.Area()); // returns 10 
            // this works because you can supply a child instance in place of a parent. This is polymorphism
            // // because area is a virtual method, at run time, CLR will realise that x is an instance of Rectangle, it will invoke the method from Rectangle class
        }
    }
}
