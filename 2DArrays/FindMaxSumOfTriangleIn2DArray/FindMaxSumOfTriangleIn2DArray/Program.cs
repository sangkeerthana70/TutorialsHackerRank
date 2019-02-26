using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxSumOfTriangleIn2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // defines a array of arrays or jagged array
            int[][] arr = new int[6][];
            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            */

            // two dimensional array
            int[,] a = new int[6, 6] {
                { 1, 1, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0 },
                { 1, 1, 1, 0, 0 ,0 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0 }
            };

            // access the tip of the triangle
            // outer loop to access the rows
            for(var i = 0; i < a.GetLength(0); i++)
            {
                // inner loop to access the columns
                for(var j = 0; j < a.GetLength(1); j++)
                {
                    // print i rows and j columns
                    Console.Write(a[i,j] + " ");

                    // print x and y co-ordinates
                    //Console.WriteLine("({0},{1})", i, j);
                }
                Console.WriteLine();
            }
            
        }
    }
}
