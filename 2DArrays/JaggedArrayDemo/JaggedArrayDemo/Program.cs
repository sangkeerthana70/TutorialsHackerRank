using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // A jagged array is an array whose elements are arrays. The elements of a jagged array can be of different dimensions and sizes.A jagged array is sometimes called an "array of arrays.
            // Eg-1 to declare a jagged array
            int[][] jaggedArray = new int[3][];
            //Before you can use jaggedArray, its elements must be initialized.You can initialize the elements like this:
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };

            // Eg-2 to declare a jagged array
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };
            // Eg-3 Shorthand form to declare a jagged array
            int[][] jaggedArray3 =
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };

            // reassign 77 to the second element ([1]) of the first array ([0]):
            jaggedArray3[0][1] = 77;

            // Assign 88 to the second element ([1]) of the third array ([2]):
            jaggedArray3[2][1] = 88;

            Console.WriteLine(jaggedArray3.GetLength(0));
            for(var i = 0; i < jaggedArray3.GetLength(0); i++)
            {
                int[] innerArray = jaggedArray3[i];
                //foreach(var item in innerArray)
                //{
                //    Console.Write(item + " ");
                //}
                Console.WriteLine();
                
                for(var j = 0; j < innerArray.Length; j++)
                {
                    
                    Console.Write(jaggedArray3[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
