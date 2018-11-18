using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank";

            // Declare second integer, double, and String variables.
            // Read and save an integer, double, and String to your variables.
            
            int i2 = Convert.ToInt32(Console.ReadLine());
            //i2 = 8;
            
            double d2 = Convert.ToDouble(Console.ReadLine());
            //d2 = 4.0;
            string s2 = Console.ReadLine();
            //s2 = "is the best place to learn coding!";

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + i2);
            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:.0}", d + d2);
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + s2);
        }
    }
}
