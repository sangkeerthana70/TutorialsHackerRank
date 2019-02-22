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

        }
    }
}
