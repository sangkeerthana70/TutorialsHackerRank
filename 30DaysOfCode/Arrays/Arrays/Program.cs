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
            /*
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
            Array.Reverse(arr2);

            foreach( int i in arr2)
            {
                Console.Write(i + " ");
            }
            */

            //for (int i = 10; i >= 0; i--)
            //{
            //    Console.WriteLine(i);

            //}

            int[] arr1 = new int[] { 1, 4, 3, 2 };
            int[] arr2 = new int[4];

            int len = arr1.Length - 1;

            for(int i=len; i >= 0; i--)
            {
                Console.WriteLine("i = " + i);
                Console.WriteLine("arr1[i] = " + arr1[i] );
                Console.WriteLine();
                
                arr2[len - i] = arr1[i];
            }
            Console.WriteLine("Copy reversed element in arr1 to arr2");
            foreach ( int num in arr2)
            {
                Console.Write(num);
            }
            Console.WriteLine();

            
        }
    }
}
