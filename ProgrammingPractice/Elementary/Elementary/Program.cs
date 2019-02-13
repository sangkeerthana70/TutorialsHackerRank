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
            

        }
    }
}
