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
                //calculate sum of all numbers in an array
                sum += arr[i];
                //calculte the average of all numbers in an array
                average = sum / arr.Length;

                //to sum two consecutive numbers in an array
                int sumTwoNums = 0;
                if (arr[i] == arr.Length - 1)
                {
                    Console.WriteLine(sumTwoNums);
                    sumTwoNums = arr[i] + arr[0];
                }
                Console.WriteLine(sumTwoNums);
                sumTwoNums += arr[i] + arr[i + 1];
                
                
                Console.WriteLine("sum two nums: " + sumTwoNums);

                //calculate the minimum value in an array
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
