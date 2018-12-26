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

            //List<int> s = new List<int>() { 4 };
            //int d = 4;
            //int m = 1;
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
                //reset checkSumlength to zero here
                int checkSumLength = 0;
                //another loop to get the portion of chocolate squares equal to the birth month(m)
                for( int j = i; j < i + m; j++)
                {
                    Console.WriteLine("j: " + j);
                    Console.WriteLine("s[j]: " + s[j]);
                    Console.WriteLine("i + m: " + i + m);
                    Console.WriteLine("List count: " + s.Count);
                    if (j == s.Count - 1)
                    {
                        checkSumLength = s[j];
                    }
                    else
                    {
                        checkSumLength = s[j] + s[j + 1];
                    }
                    Console.WriteLine("sum: " + checkSumLength);

                    if (checkSumLength == d)
                    {
                        noOfPortions += 1;
                    }
                   
                }

            }
            
            Console.WriteLine("NoOfPortions: " + noOfPortions);
            return noOfPortions;
    

        }
    }
}
