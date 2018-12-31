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
            Square square1 = new Square(8, "red");
            // call the public static variable inside Square class directly without instantiation
            Console.WriteLine("Number of squares constructed through square object = " + Square.numberOfSquares);
            Console.WriteLine(square1.ThreeDShape());
            Console.WriteLine("square1.Color " + square1.color);
            Program.Sort(square1);
            Square square2 = new Square(12, "blue");
            Console.WriteLine("Number of squares constructed through square object = " + Square.numberOfSquares);
            Console.WriteLine(square2.ThreeDShape());
            Sort(square2);
            Square square3 = new Square(4, "green");            
            Console.WriteLine("Number of squares constructed through square object = " + Square.numberOfSquares);
            Console.WriteLine(square3.ThreeDShape());
            Program.Sort(square3);


            //call the static method Definition inside the Rectangle class without any instantiation
            Rectangle.Definition();
            Rectangle rectangleA = new Rectangle(2, 4, "red");
            // call the public static variable inside Rectangle class directly without instantiation
            Console.WriteLine("Number of rectangles constructed through Rectangle object = " + Rectangle.numberOfRectangles);
            Console.WriteLine(rectangleA.ThreeDShape());
            Sort(rectangleA);
            Rectangle rectangleB = new Rectangle(6, 8, "blue");
            Console.WriteLine("Number of rectangles constructed through Rectangle object = " + Rectangle.numberOfRectangles);
            Console.WriteLine(rectangleB.ThreeDShape());
            Sort(rectangleB);
            Rectangle rectangleC = new Rectangle(10, 12, "green");
            Console.WriteLine("Number of rectangles constructed through Rectangle object = " + Rectangle.numberOfRectangles);
            Console.WriteLine(rectangleC.ThreeDShape());
            Sort(rectangleC);

            Circle.Definition();
            Circle circle = new Circle(4, "red");
            Console.WriteLine("Number of circles constructed through Circle object = "+ Circle.numberOfCircles);
            Console.WriteLine(circle.ThreeDShape());
            Sort(circle);
            Circle circle1 = new Circle(6, "blue");
            Console.WriteLine("Number of circles constructed through Circle object = " + Circle.numberOfCircles);
            Console.WriteLine(circle1.ThreeDShape());
            Sort(circle1);
            Circle circle2 = new Circle(8, "green");
            Console.WriteLine("Number of circles constructed through Circle object = " + Circle.numberOfCircles);
            Console.WriteLine(circle2.ThreeDShape());
            Sort(circle2);
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

            Box.Add(circle);
            Box.Add(circle1);
            Box.Add(circle2);

            foreach (Shape item in Box)
            {

                item.About();
            }


        }

        // Example of Polymorphism
        //static method Sort which accepts a Shape datatype and can accept any object that is passed to it
        //the object can be a derived class or a child which can be substituted for the main Base class. 
        //One exception is if the method accepts a child and not a parent you cannot substitute it with a parent class
        public static void Sort(Shape myObject)
        {
            Console.WriteLine("In sort method");
            Console.WriteLine("myObject.color: " + myObject.color);
            if(myObject.color == "red")
            {
                Console.WriteLine("Moving object to red bin");
            }
            if(myObject.color == "green")
            {
                Console.WriteLine("Moving object to green bin");
            }
            if(myObject.color == "blue")
            {
                Console.WriteLine("Moving object to blue bin");
            }

        }
    }
}
