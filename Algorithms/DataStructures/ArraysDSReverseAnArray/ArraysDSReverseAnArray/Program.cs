using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDSReverseAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 4, 3, 2 };
            int[] result = reverseArray(arr);
            Console.WriteLine(String.Join(",", result));
        }

        // Complete the reverseArray function below.
        static int[] reverseArray(int[] a)
        {
            int length = a.Length -1;
            int[] reverseArray = new int[a.Length];
            for (int i = length; i >= 0; i--)
            {
                //Console.WriteLine("i = " + i);
                //Console.WriteLine("a[i] = " + a[i]);
                reverseArray[length - i] = a[i];
                //Console.WriteLine("reverseArray[length - i] : " + reverseArray[length-i]);
            }
            return reverseArray;
        }
    }
}
