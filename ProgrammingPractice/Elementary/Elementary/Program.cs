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

            // 1- program that asks the user for their name and greets them with their name.
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);


            // 2- Modify the previous program such that only the users Alice and Bob are greeted with their names.
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
            

            // 3-program that asks the user for a number n and prints the sum of the numbers 1 to n

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

            // 4-Modify the previous program such that only multiples of three or five are considered in the sum, e.g. 3, 5, 6, 9, 10, 12, 15 for n=17

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

            
            // program that asks the user for a number n and gives them the possibility to choose between computing the sum and computing the product of 1,…,n.

            Console.WriteLine("Please enter a number");
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Do you want the sum or product of the number ");
            string decision = Console.ReadLine();

            if (decision.Equals("sum"))
            {
                int sum2 = 0;
                for(var i = 1; i <= input; i++)
                {
                    sum2 += i;
                    Console.WriteLine("sum: " + i);
                }
                Console.WriteLine("Sum of numbers from 1 " + " to " + input + " is " + sum2);
            }
            else
            {
                int product = 1;
                for(var i = 1; i <= input; i++)
                {
                    product *= i;
                    Console.WriteLine(" product *  " + i + " is " + product);
                }
                Console.WriteLine("product "  + product);
            }

            

            //  program that prints a multiplication table for numbers up to 12.

            Console.WriteLine("Enter a number to print the multiplication table");
            int number =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);

            int product = 1;
            for(var i = 1; i <= 12; i++)
            {
                product = number * i;
                Console.WriteLine(i + " * " + number + " is " + product);
            }


            // a program that prints all prime numbers

            Console.WriteLine("Enter a number: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            bool result = IsPrime(inputNum);
            
            

            // guessing game
            Random rand = new Random();
            int randNumToGuess = rand.Next(10);
            Console.WriteLine(randNumToGuess);
            

            int i = 1;
            while (true)
            {
                Console.WriteLine("Guess a number between 1 and 10");
                int guess = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Attempt number: " + i);
                if(i <= 5)
                {
                    if (randNumToGuess == guess)
                    {
                        Console.WriteLine("Congratulations you have won");
                        Console.WriteLine("You guessed correct number: " + guess);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You guessed incorrect number: " + guess);
                        Console.WriteLine("You have " + (5 - i) + " more attempts ");
                    }
                }
                else
                {
                    Console.WriteLine("You have no more attempts");
                    break;
                }
                i++;
            }
            */

            // program that prints the next 20 leap years
            int year = 2008;
            for(var i = 0; i <= 20; i++)
            {
                if((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine("Input is a leap year");
                }
                else
                {
                    Console.WriteLine("Input is not a leap year");
                }
            }







            //Console.WriteLine(");


        }

        static bool IsPrime(int inputNum)
        {
            int prime = 0;
            for (var i = 2; i < inputNum; i++)
            {
                if (inputNum % i == 0)
                {
                    Console.WriteLine("i is " + i);
                    Console.WriteLine("inputNum % i : " + inputNum % i);
                    Console.WriteLine(inputNum + " is not prime");
                    return false;
                }
                else
                {
                    Console.WriteLine("i is " + i);
                    Console.WriteLine("inputNum % i : " + inputNum % i);
                    Console.WriteLine(inputNum + " is prime ");
                }
            }
            return true;
        }

    }
}
