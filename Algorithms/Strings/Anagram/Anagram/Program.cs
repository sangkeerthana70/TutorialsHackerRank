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
            string [] splitString = s.Split();
            foreach(var item in splitString)
            {
                Console.WriteLine("item: " + item);
            }


            return mismatchCount;
        }
    }
}
