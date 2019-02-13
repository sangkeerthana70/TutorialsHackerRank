using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");

            // program that asks the user for their name and greets them with their name.
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);


            // Modify the previous program such that only the users Alice and Bob are greeted with their names.
            while (true)
            {
                Console.WriteLine("Please enter your name: ");
                string userInput = Console.ReadLine();
                if ((userInput == "Bob") || (userInput == "Alice"))
                {
                    Console.WriteLine("Hello " + userInput);
                    break;
                }
            }
            */

            // program that asks the user for a number n and prints the sum of the numbers 1 to n

            Console.WriteLine("Please enter a number");
            int numInput = Int32.Parse(Console.ReadLine());
            Console.WriteLine(numInput);
            int sum = 0;
            for(var i = 0; i <= numInput; i++)
            {
                sum += i;
                //Console.WriteLine("Sum of: " + i + " is " + sum);
                
            }
            Console.WriteLine("Sum : " + sum);

            // Modify the previous program such that only multiples of three or five are considered in the sum, e.g. 3, 5, 6, 9, 10, 12, 15 for n=17

            int n = 17;
            int sum1 = 0;
            for(var i = 0; i < n; i++)
            {
                if((i % 3 == 0) || (i % 5 == 0))
                {
                    sum1 += i;
                    Console.WriteLine("Sum of: " + i + " is " + sum1);
                }
            }
            Console.WriteLine("sum of multiples of 3 and 5 less than 17 : " + sum1);
        }
    }
}
