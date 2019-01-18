using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLoopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints a right aligned staircase
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < (5 - i) - 1; j++)
                {
                    //print space
                    Console.Write(" ");
                }
                for(int k = 0; k <= i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

            }

            // prints a pyramid of numbers
            for(int i = 1; i <= 5; i++)
            {
                //print j's value equal to i
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            
        }
    }
}
