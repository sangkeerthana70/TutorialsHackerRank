using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfStairCase = 25;
            staircase(sizeOfStairCase);
        }

        // Complete the staircase function below.
        static void staircase(int n)
        {

            //for (int i = 0; i < (n); i++)
            //{
            //    Console.WriteLine(" ");
            //    for (int j = 0; j < n - i - 2; j++)
            //    {

            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k <= i; k++)
            //    {
            //        Console.Write("#");
            //    }
            //    //Console.WriteLine();
            //}
            //Console.WriteLine();

            
            //for (int i = 0; i < n; i++)
            //{    
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("#");
            //    }               
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //-------------------------------------------------------
            for(int i = 0; i < n; i++)
            {
                //print spaces first that is less than n - i - 1 for each row
                for (int j = 0; j < (n - i) - 1; j++)
                {
                    Console.Write("0");                  
                }
                // print # symbol in the same row after the space
                for(int k = 0; k <= i; k++)
                {
                    Console.Write("#");
                }
                // move to the next line for the next row to be printed
                Console.WriteLine(" ");
            }            
 
        }

    }
}
