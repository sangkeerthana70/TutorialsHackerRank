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
            int [] a = new int[] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 };
            int d = 13;
            
            int[] result = rotLeft(a, d);
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int len = a.Length;
            int j = 0;
            int[] newArr = new int[len];

            // copy array from a to array newArr
            //for(var i = 0; i < a.Length; i++)
            //{
            //    newArr[i] = a[i];
            //    Console.WriteLine("newArr[i] : " + newArr[i]);
            //}
            //Console.WriteLine(string.Join(" ", newArr));
            //return newArr;
            //-------------------------------------------------------------
            /* brute force way to rotate array for a given position
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
            */

            
            for (var i = 0; i < len; i++)
            {
                Console.WriteLine("i "+ i);
                j = i + d;
                Console.WriteLine("j: " + j);
                newArr[i] = a[j % len];// use modulus to shift the position in new array
            }
            Console.WriteLine(string.Join(" ", newArr));
            return newArr;
        }
    }
}
