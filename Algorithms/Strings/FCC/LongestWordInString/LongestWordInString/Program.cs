using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordInString
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string s = "The quick brown fox jumped over the lazy dog";
            int longestWord = FindLongestWord(s);

        }
        public static int FindLongestWord(string s)
        {
            string[] strSplit = s.Split(' ');
            string currWord;
            int currLength;
            int maxLength = 0;

            for(int i = 0; i < strSplit.Length; i++)
            {
                currWord = strSplit[i];
                Console.WriteLine("currWord: " + currWord);
                currLength = currWord.Length;
                Console.WriteLine("curr word Length: " + currLength);
                if(maxLength < currLength)
                {
                    maxLength = currLength;
                }
            }
            Console.WriteLine("Max Length: ");
            return maxLength;
        }
    }
}
