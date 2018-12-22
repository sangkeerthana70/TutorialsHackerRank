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
            int[] arr = new int[] { 12, 3, 5 };

            int[] arr2 = new int[] { };
            
             Array.Sort(arr);
            
           
            Console.WriteLine("After sorting the elements in arr: ");
            foreach(int sortedItem in arr)
            {               
                Console.Write(sortedItem);
                Console.WriteLine();
            }
            //if length is even 
            //if length is odd
        }
    }
}
