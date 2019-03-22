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


            //for (int i = 0; i < 6; i++)
            //{
            //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //}

            int result = hourglassSum(arr);
        }

        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {

            // Display the array elements:
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            return 0;
        }
    }
}
