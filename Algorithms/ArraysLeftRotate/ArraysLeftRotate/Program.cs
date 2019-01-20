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
            int d = 1;
            int[] result = rotLeft(a, d);
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int[] newArr = new int[5];
            //for(var i = 0; i < a.Length; i++)
            //{
            //    newArr[i] = a[i];
            //    Console.WriteLine("newArr[i] : " + newArr[i]);
            //}
            //Console.WriteLine(string.Join(" ", newArr));
            //return newArr;

            for (var i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a.Len: " + a.Length);
                if (i == a.Length - 1)
                {
                    newArr[i] = a[0];
                }
                else
                {
                    newArr[i] = a[i + d];
                }
            }
            Console.WriteLine(string.Join(" ", newArr));
            return newArr;
        }
    }
}
