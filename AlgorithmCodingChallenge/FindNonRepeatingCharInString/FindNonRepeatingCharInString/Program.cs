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

            string s = "abcabd";

            char result = FindNonRepeatChar(s);
            Console.WriteLine("result " + result);

        }

        


        public static char FindNonRepeatChar(string s)
        {
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
