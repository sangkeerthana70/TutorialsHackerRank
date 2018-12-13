using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 5, 2, 7 };

            //count even numbers in an array
            //    int countEvenNum = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] % 2 == 0)
            //        {
            //            countEvenNum += 1;
            //        }
            //    }
            //    Console.WriteLine(countEvenNum); 


            //Find minimum number in an array
            int minValue = int.MaxValue;
            int sum = 0;
            int average = 0;
            Console.WriteLine(minValue);
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                average = sum / arr.Length;

                int sumTwoNums = 0;
                sumTwoNums += arr[i];
                Console.WriteLine("sum two nums: " + sumTwoNums);
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                    
                }

                
            }
            Console.WriteLine("Min num in array: " + minValue);
            Console.WriteLine("Sum of all elements in array: " + sum);
            Console.WriteLine("Average: " + average);
            //Console.WriteLine("Sum two nums: ");

        }

    }
}
