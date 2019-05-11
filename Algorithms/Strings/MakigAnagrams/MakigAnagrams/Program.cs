using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakigAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "cde";
            string s2 = "abc";
            int result = makingAnagrams(s1, s2);

        }

        // two strings are considered to be anagrams of each other if the first string's letters can be 
        // rearranged to form the second string. In other words, both strings must contain the same exact
        //letters in the same exact frequency. 


        // Complete the makingAnagrams function below.

        static int makingAnagrams(string s1, string s2)
        {
            int commonChar = 1;
            int minDeletions = 0;
            Dictionary<char, int> strDict1 = new Dictionary<char, int>();

            for(int i = 0; i < s1.Length; i++)
            {
                if (strDict1.ContainsKey(s1[i]))
                {
                    strDict1[s1[i]]++;
                }
                else
                {
                    strDict1.Add(s1[i], 1);
                }
            }

            foreach(var item in strDict1)
            {
                Console.WriteLine("item in a: " + item);
            }
            Console.WriteLine();

            Dictionary<char, int> strDict2 = new Dictionary<char, int>();

            for(int i = 0; i < s2.Length; i++)
            {
                if (strDict2.ContainsKey(s2[i]))
                {
                    strDict2[s2[i]]++;
                }
                else
                {
                    strDict2.Add(s2[i], 1);
                }
            }
            foreach(var item in strDict2)
            {
                Console.WriteLine("item in b: " + item);
            }

            foreach(KeyValuePair<char, int> character in strDict1)
            {
                if(strDict2.ContainsKey(character.Key))
                {
                    Console.WriteLine("Common key: " + character);
                    commonChar += 1;
                    Console.WriteLine("commonChar count: " + commonChar);
                    minDeletions = (s1.Length + s2.Length) - commonChar;
                    Console.WriteLine("min deletions: " + minDeletions);


                }
            }

            return minDeletions;
        }
    }
}
