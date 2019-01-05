using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNonRepeatingCharInString
{
    class Program
    {
        static void Main(string[] args)
        {

            //string s = "abcabd";
            string s = "abadababacab";

            char result = FindNonRepeatChar(s);
            Console.WriteLine("result " + result);

        }

        //1-Find the First non-repeating character in a string.
        //2-Given a string = "abcabd" return c as a first non repeating char.
        //3- additional challenge
        //Memory , variables and efficiency(MVP)Minimal viable product.Brute Force solution
        public static char FindNonRepeatChar(string s)
        {
            // resetting seen to false for every char
            char letter;
            bool seen;
            for (int i = 0; i < s.Length; i++)
            {
               
                seen = false;
                letter = s[i];

                for (int j = i+1; j < s.Length; j++)
                {
                    if (s[j] == letter)
                    {
                        seen = true;
                        break;
                    }
                }

                if (!seen) return letter;
               
            }
            return '_';

        }
    }
}
