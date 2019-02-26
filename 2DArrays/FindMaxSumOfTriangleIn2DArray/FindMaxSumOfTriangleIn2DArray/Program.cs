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

            /*
            // access the tip of the triangle
            // outer loop to access the rows
            for(var i = 0; i < a.GetLength(0) - 1; i++)
            {
                // inner loop to access the columns
                for(var j = 1; j < a.GetLength(1); j++)
                {
                    // print i rows and j columns
                    Console.Write(a[i,j] + " ");

                    // print x and y co-ordinates
                    //Console.WriteLine("({0},{1})", i, j);
                }
                Console.WriteLine();
            }
            */

            // Calculate the max sum of the triangle in the 2D array
            int triangleSum = 0;

            int maxValue = int.MinValue;
            for (var i = 0; i < a.GetLength(0) - 1; i++)
            {
                Console.WriteLine("i: " + i);
                for (var j = 1; j < a.GetLength(1) - 1; j++)
                {
                    Console.WriteLine("j: " + j);
                    Console.WriteLine("a[i, j]: " + a[i, j]);
                    triangleSum = a[i, j];
                    Console.WriteLine("a[i + 1, j-1]:" + a[i + 1, j - 1]);
                    Console.WriteLine("a[i + 1, j]" + a[i + 1, j]);
                    Console.WriteLine("a[i + 1, j + 1]" + a[i + 1, j + 1]);
                    triangleSum += a[i + 1, j - 1] + a[i + 1, j] + a[i + 1, j + 1];
                    Console.WriteLine("triangleSum: " + triangleSum);
                    if (triangleSum > maxValue)
                    {
                        maxValue = triangleSum;
                    }
                }
                //Console.WriteLine("triangleSum: " + triangleSum);
            }
            Console.WriteLine("maxValue: " + maxValue);


        }
    }
}
