using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOddOrEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i + " is even");
                }
                else
                {
                    Console.WriteLine(i + " is odd");
                }
            }
        }
    }
}
