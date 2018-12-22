using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcMedianOfNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 3, 5, 7, 12, 13, 14, 21, 23, 23, 23, 23, 29, 40, 56 };

            //int[] arr = new int[] { 38, 50, 97, 20 };

            int[] arr = new int[] { 30, 8, 41, 95, -3, 62 };
             Array.Sort(arr);

            int median = 0;
            int arrLength =  arr.Length;
            Console.WriteLine("After sorting the elements in arr: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("sortedItem: " + arr[i]);
                Console.WriteLine();

                //if length of arr is odd
                
                if (arrLength % 2 != 0)
                {
                    Console.WriteLine(arr.Length % 2);
                    median = arr[arrLength / 2];
                    Console.WriteLine("median: " + median);
                }
                //if length is even
                else
                {
                    
                    Console.WriteLine("Middle element1: " + arr[(arrLength / 2) - 1]);
                    Console.WriteLine("Middle element2: " + arr[arrLength / 2]);
                    median = (arr[arrLength / 2] + arr[(arrLength / 2) - 1]) / 2;
                    Console.WriteLine("Median: " + median);
                }
            }
            
             




        }
    }
}
