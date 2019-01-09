using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopyFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program to copy elements from one array into another array
            int[] arr1 = new int[] {7, 2, 5, 9, 11 };
            int[] arr2Result = CopyArrayIntoANother(arr1);
            
        }

        public static int[] CopyArrayIntoANother(int [] arr)
        {
            int[] arr2 = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
                Console.WriteLine("arr2[i] : " + arr2[i]);
            }
            return arr2;
        }
    }
}
