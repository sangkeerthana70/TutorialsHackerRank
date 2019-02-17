using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = "world";
            string result = TwoStrings(a, b);
            Console.WriteLine("Result: " + result);

        }

        // Complete the twoStrings function below.
        static string TwoStrings(string s1, string s2)
        {
            string subStr = "";
            Console.WriteLine(s2.Length);

            for(var j = 0; j < s1.Length; j++)
            {
                Console.WriteLine("j: " + j);
                Console.WriteLine("s1[j] : " + s1[j]);
                for (var i = 0; i < s2.Length; i++)
                {
                    Console.WriteLine("s2[i] : " + s2[i]);

                    if (s1[j] == s2[i])
                    {
                        //match += s1[j];
                        //Console.WriteLine("match: " + match);
                        subStr = "YES";
                        return subStr;
                    }
                    else
                    {
                        //noMatch += s2[i];
                        //Console.WriteLine("noMatch: " + noMatch);
                        subStr = "NO";

                    }
                }
            }

            return subStr;
 
        }
    }
}
