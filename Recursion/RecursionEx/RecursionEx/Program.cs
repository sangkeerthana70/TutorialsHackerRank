using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int m = 14;
            int result = CalculateSumRecursively(n, m);
            Console.WriteLine(result);
        }

        public static int CalculateSumRecursively(int n, int m)
        {
            int sum = n;

            if (n < m)
            {
                n++;
                return sum += CalculateSumRecursively(n, m);
            }

            return sum;
        }
    }
}
