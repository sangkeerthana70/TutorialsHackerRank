using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // call the static method Definition inside the Square class without any instantiation
            Square.Definition();
            Square square1 = new Square(8);
            // call the public static variable inside Square class directly without instantiation
            Console.WriteLine("Number of squares constructed through square object = " + Square.numberOfSquares);
            Console.WriteLine(square1.ThreeDShape()); 
            Square square2 = new Square(12);
            Console.WriteLine("Number of squares constructed through square object = " + Square.numberOfSquares);
            Console.WriteLine(square2.ThreeDShape()); 
            Square square3 = new Square(4);            
            Console.WriteLine("Number of squares constructed through square object = " + Square.numberOfSquares);
            Console.WriteLine(square3.ThreeDShape());


            //call the static method Definition inside the Rectangle class without any instantiation
            Rectangle.Definition();
            Rectangle rectangleA = new Rectangle(2, 4);
            // call the public static variable inside Rectangle class directly without instantiation
            Console.WriteLine("Number of rectangles constructed through Rectangle object = " + Rectangle.numberOfRectangles);
            Console.WriteLine(rectangleA.ThreeDShape());
            Rectangle rectangleB = new Rectangle(6, 8);
            Console.WriteLine("Number of rectangles constructed through Rectangle object = " + Rectangle.numberOfRectangles);
            Console.WriteLine(rectangleB.ThreeDShape());
            Rectangle rectangleC = new Rectangle(10, 12);
            Console.WriteLine("Number of rectangles constructed through Rectangle object = " + Rectangle.numberOfRectangles);
            Console.WriteLine(rectangleC.ThreeDShape());

            //Circle.Definition();
            //Circle circle = new Circle(4);
            //Console.WriteLine("Number of circles constructed through Circle object = "+ Circle.numberOfCircles);
            //Console.WriteLine(circle.ThreeDShape());


            // Create a new List called Box and add squares and rectangles object in it

            List<Shape> Box = new List<Shape>();
            // override keyword makes the square class override the base class's About method
            Box.Add(square1);
            Box.Add(square2);
            Box.Add(square3);

            // override keyword makes the rectangle class override the base class's About method
            Box.Add(rectangleA);
            Box.Add(rectangleB);
            Box.Add(rectangleC);

            //Box.Add(circle);

            foreach (Shape item in Box)
            {

                item.About();
            }


        }
    }
}
