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
            string a = "r";
            string b = "art";
            string result = TwoStrings(a, b);
            Console.WriteLine("Result: " + result);

        }

        // Complete the twoStrings function below.
        static string TwoStrings(string s1, string s2)
        {
            bool match = false;
            string subStr = "";
            string returnStr = "";
            string noMatchStr = "";
            for(var i = 0; i < s2.Length; i++)
            {
                if(s1[i] == s2[i])
                {
                    
                    subStr += s1[i];
                    Console.WriteLine(subStr);
                    return returnStr += "YES";
                }
                

            }

            return noMatchStr += "NO";
            
            


        }
    }
}
