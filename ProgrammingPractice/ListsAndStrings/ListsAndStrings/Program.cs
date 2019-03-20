using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // function that returns the largest element in a list.
            List<int> numbers = new List<int> { 11, 13, 15, 5, 7, 9 };

            int maxValue = int.MinValue;
            for(var i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
            }
            Console.WriteLine("max value: " + maxValue);
            */

            int num = 12;
            int[] result = GetFactors(num);
            Console.WriteLine(String.Join(",", result));
        }

        static int[] GetFactors(int num)
        {
            int[] factors = new int[num + 1];

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    //Console.WriteLine("Loop : " + i);
                    //Console.WriteLine(num + " % " + i + " == 0");
                    factors[i] = i;

                }
                //else
                //{
                    //Console.WriteLine("Loop : " + i);
                    //Console.WriteLine(num + " % " + i + " != 0");
                //}
            }
            //foreach (int number in factors)
            //{
            //    Console.WriteLine("Num : " + number);
            //}
            return factors;

        }
    }
}
