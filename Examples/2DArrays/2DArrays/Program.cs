using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 4] {
                { 0, 1, 2, 3 },
                { 4, 5, 6, 7 },
                { 8, 9 ,10, 11 }

            };
            // accessing 2-D array elements
            int getElem = a[0, 1];
            int elem = a[1, 2];
            int val = a[2, 3];
            Console.WriteLine(getElem);
            Console.WriteLine(elem);
            Console.WriteLine(val);


            /* an array with 5 rows and 2 columns*/
            int[,] b = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            int i, j;

            /* output each array element's value */
            for (i = 0; i < 5; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, b[i, j]);
                }
            }
            Console.ReadKey();

        }
    }
}
