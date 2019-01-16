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
            string longestWord = FindLongestWord(s);

        }

        public static string FindLongestWord(string s)
        {
            string[] strSplit = s.Split(' ');
            string currWord;
            int currLength;
            int maxLength = 0;
            string longestWord = "";
            // program to find the longest word in a string
            for(int i = 0; i < strSplit.Length; i++)
            {
                currWord = strSplit[i];
                Console.WriteLine("currWord: " + currWord);
                currLength = currWord.Length;
                Console.WriteLine("curr word Length: " + currLength);
                if(maxLength < currLength)
                {
                    maxLength = currLength;
                    longestWord = currWord;
                }
            }
            Console.WriteLine("Max Length: " + maxLength);
            Console.WriteLine("Longest word: " + longestWord);
            return longestWord;
        }
    }
}
