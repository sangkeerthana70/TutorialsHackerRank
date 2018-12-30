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
            
            int misMatchCount = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                bool match = false;
                Console.WriteLine("Outer loop : " + s1[i]);
                for (int j = 0; j < s2.Length; j++)
                {
                    Console.WriteLine("Inner loop : " + s2[i]);
                    if (s1[i] == s2[j])
                    {
                        Console.WriteLine("match");
                        match = true;
                        break;
                    }

                }
                if(!match)
                {
                    misMatchCount += 1;
                    Console.WriteLine("No match : " + misMatchCount);
                }



            }

            //compare string s2 with string s1
            for (int i = 0; i < s2.Length; i++)
            {
                Console.WriteLine("outer loop: " + s2[i]);
                bool match = false;
                for (int j = 0; j < s1.Length; j++)
                {
                    Console.WriteLine("Inner loop: " + s1[j]);
                    if (s2[i] == s1[j])
                    {
                        Console.WriteLine("match");
                        match = true;
                        break;
                    }
                }
                if (!match)
                {
                    Console.WriteLine("no match");
                    misMatchCount++;
                    Console.WriteLine("mismatchCount " + misMatchCount);
                }
            }
            return misMatchCount;



        }
    }
}
