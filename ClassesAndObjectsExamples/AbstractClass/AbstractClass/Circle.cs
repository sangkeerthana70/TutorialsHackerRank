using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Circle : Shape
    {
        private int radius;
        public static int numberOfCircles;
        

        public Circle(int r, string c) : base()
        {
            this.radius = r;
            numberOfCircles++;
            this.color = c;
        }

        private double Perimeter()
        {
            double perimeter = 2 * 3.14 * radius;
            return perimeter;
        }

        private double Area()
        {
            double area = 3.14 * radius * radius;
            return area;
        }

        public override void About()
        {
            Console.Write("I am a circle with a radius of " + radius);

            Console.Write(" My Perimeter is " + this.Perimeter());
            Console.Write(" My area is " + this.Area());
            Console.WriteLine(" I am " + this.color + " in color.");
            Console.WriteLine();
        }
        public static void Definition()
        {
            Console.WriteLine("A circle is a 2 - dimensional shape made by drawing a curve that is always the same distance from a center.");
        }


        // implement the ThreeDShape() method of the base class which is abstract
        public override string ThreeDShape()
        {
            return "Cylinder";
        }

    }
}