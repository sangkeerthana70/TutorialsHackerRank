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


            //List <Square> squares = new List <Square> ();
            //squares.Add(square1);
            //squares.Add(square2);
            //squares.Add(square3);
            //foreach(Square item in squares)
            //{
            //    item.About();
            //}

            //----------------------------------------------------------
            //instantiate rectangle class into many objects

            Rectangle rectangleA = new Rectangle(2, 4);
            Rectangle rectangleB = new Rectangle(6, 8);
            Rectangle rectangleC = new Rectangle(10, 12);

            //List<Rectangle> rectangles = new List<Rectangle>();
            //rectangles.Add(rectangleA);
            //rectangles.Add(rectangleB);
            //rectangles.Add(rectangleC);

            //foreach(Rectangle item in rectangles)
            //{
            //    item.About();
            //}


            // Create a new List called Box and add squares and rectangles object in it

            List<Shapes> Box = new List<Shapes>();

            Box.Add(square1);
            Box.Add(square2);
            Box.Add(square3);

            Box.Add(rectangleA);
            Box.Add(rectangleB);
            Box.Add(rectangleC);

            foreach(Shapes item in Box)
            {
                item.About();
            }

            
            
        }
    }
}
