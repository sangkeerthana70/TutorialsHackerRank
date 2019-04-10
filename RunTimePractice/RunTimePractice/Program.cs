using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "abca";
            char c = 'a';
            long startTime = DateTime.Now.Millisecond;
            int res = findRepeatedOccuranceOfACharInString(S, c);
            Console.WriteLine("res: " + res);
            long endTime = DateTime.Now.Millisecond;
            long duration = endTime - startTime;
            Console.WriteLine("Time taken in milliseconds: " + duration);
        }

        public static int findRepeatedOccuranceOfACharInString(string S, char c)
        {
            int occurance = 0;
            for(int i = 0; i < S.Length; i++)
            {
                //Console.WriteLine(S.Contains(c));
                if (S.Contains(c))
                {
                    occurance++;
                }
            }
            return occurance;
        }
    }
}
