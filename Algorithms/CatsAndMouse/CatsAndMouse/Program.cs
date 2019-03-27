using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsAndMouse
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] input = new int[] { 1, 2, 3 };
            int[] input1 = new int[] { 1, 3, 2 };
            
            
            string result = catAndMouse(input);
            Console.WriteLine("result: " + result);
            
            
        }

        // Complete the catAndMouse function below.
        static string catAndMouse(int[] input)
        {
            string result = "";
            
            
                if(Math.Abs((input[2] - input[0])) > Math.Abs((input[2] - input[1])))
                {
                    Console.WriteLine("in first if");
                    Console.WriteLine((input[2] - input[0]));
                    Console.WriteLine((input[2] - input[1]));
                    result += "Cat B";
                }
                else if((Math.Abs(input[2] - input[1]) < Math.Abs(input[2] - input[0])))
                {
                    Console.WriteLine("in else if");
                    Console.WriteLine((input[2] - input[1]));
                    Console.WriteLine((input[2] - input[1]));
                    result += "Cat A";
                }
                else
                {
                    result += "Mouse C";
                }
            
            return result;

        }
    }
}
