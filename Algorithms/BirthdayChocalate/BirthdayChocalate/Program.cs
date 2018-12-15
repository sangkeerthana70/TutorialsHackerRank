using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayChocalate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> s = new List<int>() { 1, 2, 1, 3, 2 };
            int d = 3;//date of birthday
            int m = 2;//month
            int result = birthday(s, d, m);
        }

        // Complete the birthday function below.
        static int birthday(List<int> s, int d, int m)
        {
            int checkSumLength = 0;
            int noOfsquares = 0;
            Console.WriteLine("List count: " + s.Count);
            for (int i = 0; i < s.Count; i++)
            {
                Console.WriteLine("Loop: " + i);
                Console.WriteLine("s[i]: " + s[i]);
                checkSumLength = 0;
                
                for (int j = i; j < s.Count; j++)
                {
                    
                    Console.WriteLine("J is: " + j);
                    Console.WriteLine("s[j]: " + s[j]);
                    checkSumLength += s[j];
                    Console.WriteLine("Sum: " + checkSumLength);
                    if (checkSumLength == d)
                    {
                        noOfsquares += 1;
                        break;
                        
                        Console.WriteLine("Skip to next elem in array");
      
                    }
                    else
                    {
                       
                        Console.WriteLine("Sum is not equal to date");
                    }
                      
                }
               
            }
            Console.WriteLine("NoOfSquares: " + noOfsquares);
            return noOfsquares;

        }
    }
}
