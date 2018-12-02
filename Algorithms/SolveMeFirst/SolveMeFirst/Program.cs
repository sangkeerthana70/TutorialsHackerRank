using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveMeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int sum = solveMeFirst(a, b);
        }

        static int solveMeFirst(int a, int b)
        {
            // Hint: Type return a+b; below  
            int sum = a + b;
            Console.WriteLine(sum);
            return sum;           
        }

    }
}
