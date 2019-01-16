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
            List<int> s = new List<int>() { 4 };
            int d = 4;//date of birthday
            int m = 1;//month
            int result = birthday(s, d, m);

            //List<int> s = new List<int>() { 4 };
            //int d = 4;
            //int m = 1;
        }

        // Complete the birthday function below.
        static int birthday(List<int> s, int d, int m)
        {
            int checkSumLength = 0;
            int noOfPortions = 0;
            //Console.WriteLine("List count: " + s.Count);
            
            for (int i = 0; i < s.Count - 1; i++)
            {
                if (s.Count == 1)
                {
                    Console.WriteLine("IN HERE");
                    if (s[i] == d)
                    {                       
                        checkSumLength = s[i];
                        Console.WriteLine("Length: " + checkSumLength);
                        noOfPortions += 1;
                    }                       
                }
                else
                {
                    if ((s[i] + s[i + 1]) == d)
                    {
                        noOfPortions += 1;
                        checkSumLength = s[i] + s[i + 1];
                        Console.WriteLine(checkSumLength);
                    }
                }
            }
            Console.WriteLine("no of portions :" + noOfPortions);
            return noOfPortions;
        }
    }
}
