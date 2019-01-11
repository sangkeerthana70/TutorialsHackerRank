using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 12;
            int []result = GetFactors(num);
        }

        // Factors are what we can multiply to get the number Eg:1 x 6 = 6 so 1 and 6 are factors
        static int[] GetFactors(int num)
        {
            int[] factors = new int[num + 1];

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Loop : " + i);
                    Console.WriteLine(num + " % " + i + " == 0");
                    factors[i] = i;

                }
            }
            foreach (int number in factors)
            {
                Console.WriteLine("Num : " + number);
            }
            return factors;

        }
    }
}
