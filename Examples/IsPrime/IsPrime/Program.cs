using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool result = IsPrime(7);
            //Console.WriteLine(result);

            int[] factors = GetFactors(12);

           
        }
         
        static bool IsPrime(int num)
        {
            // find if a number is prime
            // a number is prime if it is divisible by only itself and one
           
            // Initialize i = 2 since all numbers are divisible by 1
            for( int i = 2; i < num; i++)
            {
                Console.WriteLine("Loop count: " + i);
                if (num % i == 0)
                {
                    Console.WriteLine(i + " is not prime");
                    return false;//return false once the number is divisible by any other number other than 1 and itself
                }
                else
                {
                    Console.WriteLine(num + " mod " + i + " is not zero");
                }
            }
            return true;
            
        }

        // Factors are what we can multiply to get the number Eg:1 x 6 = 6 so 1 and 6 are factors
        static int [] GetFactors(int num)
        {
            int[] factors = new int[num + 1];

            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine("Loop : " + i);
                    Console.WriteLine(num + " % " + i + " == 0");
                    factors[i] = i;
                    
                }
            }
            foreach(int number in factors)
            {
                Console.WriteLine("Num : " + number);
            }
            return factors;

        }

        static int SumEvenNumsInRange(int num)
        {
            var result = 0;
            for (var i = num1; i <= num2; i++)
            {
                if (isOdd(i))
                {
                    console.log(i);
                    result = result + i;
                    //console.log(result);
                }
            }
            return result;
        }
        
    }
}
