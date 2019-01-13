using DisplayBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawBoard(4);
        }

        public static void DrawBoard(int height)
        {
            int n = (2 * height) - 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    DrawBox(height);
                }
                else
                {
                    DrawSeparator(height);
                }
            }
            
        }
        
        //prints first line accross as " |" for the specified height
        public static void DrawBox(int height)
        {
            int n = (2 * height) - 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("|");
                }

            }
            Console.WriteLine();
        }
        // prints second line accross as "-+" for the specified height
        public static void DrawSeparator(int height)
        {
            int n = (2 * height) - 1;
            for( int j = 0; j < n; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write("+");
                }


            }
            Console.WriteLine();
        }




    }
}
