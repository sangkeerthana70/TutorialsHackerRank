using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLeftRotate
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] a = new int[] { 1, 2, 3, 4, 5 };
            int d = 2;
            int[] result = rotLeft(a, d);
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int[] newArr = new int[5];

            // copy array from a to array newArr
            //for(var i = 0; i < a.Length; i++)
            //{
            //    newArr[i] = a[i];
            //    Console.WriteLine("newArr[i] : " + newArr[i]);
            //}
            //Console.WriteLine(string.Join(" ", newArr));
            //return newArr;

            for (var i = 0; i < a.Length; i++)
            {
                Console.WriteLine("i: " + i);
                if (i == a.Length - 1)
                {
                    Console.WriteLine("a[0+1] " + a[0 + 1]);
                    newArr[i] = a[0 + 1];
                }
                else if(i == a.Length - 2)
                {
                    Console.WriteLine("a[0] " + a[0]);
                    newArr[i] = a[0];
                }
                else
                {
                    Console.WriteLine("a[i + d] :" + a[i + d]);
                    newArr[i] = a[i + d];
                }
            }
            Console.WriteLine(string.Join(" ", newArr));
            return newArr;
        }
    }
}
