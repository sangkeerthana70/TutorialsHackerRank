using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 4, 3, 2};
            int[] arr2 = new int[4];

            // Copy one array into the other
            Array.Copy(arr1, arr2, 4);
            Console.WriteLine("--- Target array ---");
            foreach (int value in arr2)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
            //Reverse an array
            // Reverses the sort of the values of the Array.
            Array.Reverse(arr1);

            foreach( int i in arr1)
            {
                Console.Write(i + " ");
            }

        }
    }
}
