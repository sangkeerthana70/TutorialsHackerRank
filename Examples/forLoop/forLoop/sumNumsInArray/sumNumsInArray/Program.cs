using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumNumsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 2, 7 };
            SumTwoConsecutiveNums(arr);

            
        }

        //program to add two consecutive numbers and return the result in an array
        public static int[] SumTwoConsecutiveNums(int [] arr)
        {
            int[] result = new int[3]; 
            for (int i = 0; i < arr.Length; i++)
            {

                if (i == arr.Length - 1)
                {
                    result[i] = arr[i];
                }
                else
                {
                    result[i] = arr[i] + arr[i + 1];
                }
                
            }
            Console.WriteLine(result);
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
            return result;
        }
    }
}
