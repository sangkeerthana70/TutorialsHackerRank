using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 100;

            if (!(n % 2 == 0))
            {
                Console.WriteLine(n + " Weird");
            }
            else
            {
                if (n > 2 && n <= 5)
                {
                    Console.WriteLine(n + " Not Weird");
                }
                else if (n > 6 && n <= 20)
                {
                    Console.WriteLine(n + " Weird");                
                }
                else
                {
                    Console.WriteLine(n + " Not Weird");
                }
            }
        }
    }
}
