using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Equal = Calculator.AreEqual<int>(20, 20);
            
            if (Equal)
            {
                Console.WriteLine("Values are Equal");
            }
            else
            {
                Console.WriteLine("Values are not equal");
            }

            bool stringEqual = Calculator.AreEqual<string>("hello", "world");
            if (stringEqual)
            {
                Console.WriteLine("String Values are Equal");
            }
            else
            {
                Console.WriteLine("String Values are not equal");
            }
        }

        public class Calculator
        {
            public static bool AreEqual<T>(T value1, T value2)
            {
                return value1.Equals(value2);
            }
        }


    }
}
