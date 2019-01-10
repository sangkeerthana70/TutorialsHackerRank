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
            bool result = IsPrime(7);
            Console.WriteLine(result);
        }
         
        static bool IsPrime(int num)
        {
            // find if a number is prime
            // a number is prime if it is divisible by only itself and one then it is prime
           
            //set i = 2 since all numbers are divisible by 1
            for( int i = 2; i < num; i++)
            {
                Console.WriteLine("Loop count: " + i);
                if (num % i == 0)
                {
                    Console.WriteLine(i + " is not prime");
                    return false;
                }
                else
                {
                    Console.WriteLine(num + " mod " + i + " is not zero");
                }
            }
            return true;
            
        }
        
}
}
