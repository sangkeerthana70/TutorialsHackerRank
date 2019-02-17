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
            string a = "hello";
            string b = "world";
            string result = TwoStrings(a, b);
            Console.WriteLine("Result: " + result);

        }

        /* Old Solution
        // Complete the twoStrings function below.
        static string TwoStrings(string s1, string s2)
        {
            string subStr = "";
            Console.WriteLine(s2.Length);

            for(var j = 0; j < s1.Length; j++)
            {
                Console.WriteLine("j: " + j);
                Console.WriteLine("s1[j] : " + s1[j]);
                for (var i = 0; i < s2.Length; i++)
                {
                    Console.WriteLine("s2[i] : " + s2[i]);

                    if (s1[j] == s2[i])
                    {
                        //match += s1[j];
                        //Console.WriteLine("match: " + match);
                        subStr = "YES";
                        return subStr;
                    }
                    else
                    {
                        //noMatch += s2[i];
                        //Console.WriteLine("noMatch: " + noMatch);
                        subStr = "NO";

                    }
                }
            }

            return subStr;
 
        }
        */

        // Complete the twoStrings function below.
        static string TwoStrings(string s1, string s2)
        {
            // Pseudocode
            // define two empty dictionary<char, int> one for string-A and one for string-B
            // loop through all the characters in the string-A eg:"hello"
            // loop through all the characters in the string-B eg:"world"
            // create a key value pair for each string in its separate dictionary
            // compare both the dictionaries and check if it has a common character which will be the substring of one in the other.
            Dictionary<char, int> strDictA = new Dictionary<char, int>();
            Dictionary<char, int> strDictB = new Dictionary<char, int>();
            string matchingChar = "";
            for(var i = 0; i < s1.Length; i++)
            {
                // if the key already exists
                if (strDictA.ContainsKey(s1[i]))
                {
                    // update the value of that already existing key
                    strDictA[s1[i]] += 1;
                }
                else
                {
                    strDictA.Add(s1[i], 1);
                }
                
            }
            

            //foreach(var pair in strDictA)
            //{
            //    Console.WriteLine("key = {0} value = {1}", pair.Key, pair.Value);
            //}

            for(var j = 0; j < s2.Length; j++)
            {
                if (strDictB.ContainsKey(s2[j]))
                {
                    strDictB[s2[j]] += 1;
                }
                else
                {
                    strDictB.Add(s2[j], 1);
                }
            }

            //foreach(var pair in strDictB)
            //{
            //    Console.WriteLine("key = {0} value = {1}", pair.Key, pair.Value);
            //}

            // compare two dictionaries
           foreach(var pair in strDictA)
           {
                if (strDictB.ContainsKey(pair.Key))
                {
                    Console.WriteLine("Found a matching char: " + pair.Key);
                    matchingChar += pair.Key;
                    // when you find one matching letter break out of the loop
                    return "YES";
                }
                else
                {
                    Console.WriteLine("No match found");
                }
           }
           Console.WriteLine("matchingChar: " + matchingChar);

           return "NO";
            

        }

    }
}
