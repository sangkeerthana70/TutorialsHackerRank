using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrays_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            arr[0] = new int[6] { -9, -9, -9, 1, 1, 1 };
            arr[1] = new int[6] { 0, -9, 0, 4, 3, 2 };
            arr[2] = new int[6] { -9, -9, -9, 1, 2, 3 };
            arr[3] = new int[6] { 0, 0, 8, 6, 6, 0 };
            arr[4] = new int[6] { 0, 0, 0, -2, 0, 0 };
            arr[5] = new int[6] { 0, 0, 1, 2, 4, 0 };


            int result = hourglassSum(arr);
            Console.WriteLine("max sum of hourglass: " + result);
        }

        /* Complete the hourglassSum function below.
          This program finds the maximum sum of hourglass in a jagged array which can have 
          varying row and column length
        */
        static int hourglassSum(int[][] arr)
        {
            /* accessing a jagged array which can have varying length of rows and columns
            // Display the array elements:
            //loop to iterate over the rows
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                // loop to iterate over the columns
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            */

            int hourGlassSum = 0;
            int maxValue = int.MinValue;
            // Outer loop to increment the row count upto row -2 to get hourglass shape
            for (int i = 0; i < arr.Length -2; i++)
            {
                // inner loop to increment the column count upto column count -2 
                for(int j = 0; j < arr[i].Length -2; j++)
                {
                    //Console.WriteLine("({0},{1})",i,j);
                    hourGlassSum = arr[i][j] + arr[i][j+1] + arr[i][j+2];
                    hourGlassSum += arr[i + 1][j + 1];
                    hourGlassSum += arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    //Console.WriteLine(hourGlassSum);

                    if (hourGlassSum > maxValue)
                    {
                        maxValue = hourGlassSum;
                    }
                }
                
            }
            return maxValue;
        }
    }
}
