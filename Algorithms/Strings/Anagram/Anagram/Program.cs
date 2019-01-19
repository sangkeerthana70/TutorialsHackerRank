using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aaabbb";
            int result = anagram(s);
        }

        // Complete the anagram function below.
        static int anagram(string s)
        {
            int mismatchCount = 0;
            int num = s.Length / 2;
            //string [] splitString = s.Split();
            //foreach(var item in splitString)
            //{
            //    Console.WriteLine("item: " + item);
            //}
            if(s.Length % 2 == 0)
            {
                string subString = s.Substring(0, num);
                Console.WriteLine("subString: " + subString);
            }

            return mismatchCount;
        }
    }
}
