using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
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
            Square square2 = new Square(12);
            Console.WriteLine("Number of squares constructed through square object = " + Square.numberOfSquares);
            Square square3 = new Square(4);
            Console.WriteLine("Number of squares constructed through square object = " + Square.numberOfSquares);


            //call the static method Definition inside the Rectangle class without any instantiation
            Rectangle.Definition();
            Rectangle rectangleA = new Rectangle(2, 4);
            // call the public static variable inside Rectangle class directly without instantiation
            Console.WriteLine("Number of rectangles constructed through Rectangle object = " + Rectangle.numberOfRectangles);
            Rectangle rectangleB = new Rectangle(6, 8);
            Console.WriteLine("Number of rectangles constructed through Rectangle object = " + Rectangle.numberOfRectangles);
            Rectangle rectangleC = new Rectangle(10, 12);
            Console.WriteLine("Number of rectangles constructed through Rectangle object = " + Rectangle.numberOfRectangles);

            //List<Rectangle> rectangles = new List<Rectangle>();
            //rectangles.Add(rectangleA);
            //rectangles.Add(rectangleB);
            //rectangles.Add(rectangleC);

            //foreach(Rectangle item in rectangles)
            //{
            //    item.About();
            //}


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

            foreach (Shape item in Box)
            {
                
                item.About();
            }


        }
    }
}
