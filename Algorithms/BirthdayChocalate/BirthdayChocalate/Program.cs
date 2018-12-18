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
            
            int noOfPortions = 0;
            //Console.WriteLine("List count: " + s.Count);
            
            for (int i = 0; i < s.Count; i++)
            {
                Console.WriteLine("i:" + i);
                Console.WriteLine("s[i]: " + s[i]);
                int checkSumLength = 0;
                for (int j = i; j < m; j++)
                {
                    
                    Console.WriteLine("j : " + j);
                    Console.WriteLine("s[j] : " + s[j]);
                    

                    checkSumLength = s[j] + s[j + 1];
                    Console.WriteLine("Sum in loop: " + checkSumLength);
                    if ( checkSumLength == d)
                    {
                        noOfPortions += 1;
                        j++;
                        Console.WriteLine("Iterating to next loop");
                    }
                    else
                    {
                        j++;
                    }
                    
                }
                
                


            }
            Console.WriteLine("NoOfPortions: " + noOfPortions);
            return noOfPortions;
    

        }
    }
}
