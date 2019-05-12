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
            string s1 = "absdjkvuahdakejfnfauhdsaavasdlkj";
            string s2 = "djfladfhiawasdkjvalskufhafablsdkashlahdfa";
            int result = makingAnagrams(s1, s2);
            Console.WriteLine("result: " + result);

        }

        // two strings are considered to be anagrams of each other if the first string's letters can be 
        // rearranged to form the second string. In other words, both strings must contain the same exact
        //letters in the same exact frequency. 


        // Complete the makingAnagrams function below.

        static int makingAnagrams(string s1, string s2)
        {
            int commonCharCount1 = 0;
            int commonCharCount2 = 0;
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

            //foreach(var item in strDict1)
            //{
            //    Console.WriteLine("item in a: " + item);
            //}
            //Console.WriteLine();

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
            //foreach(var item in strDict2)
            //{
            //    Console.WriteLine("item in b: " + item);
            //}

            // find the uncommon chars in strDict1
            foreach(KeyValuePair<char, int> character in strDict1)
            {
                if(!strDict2.ContainsKey(character.Key))
                {                    
                    minDeletions += character.Value;                   
                }               
            }
            // find the uncommon chars in strDict2
            foreach (KeyValuePair<char, int> character in strDict2)
            {
                if (!strDict1.ContainsKey(character.Key))
                {
                     minDeletions += character.Value;
                }
            }
            // find the common chars between both dicts by getting the key's value
           foreach(KeyValuePair<char, int> character in strDict1)
           {
                if (strDict2.ContainsKey(character.Key))
                {
                    commonCharCount1 = strDict1[character.Key];
                    //Console.WriteLine("common key of strDict1: " + character.Key +commonCharCount1);
                    commonCharCount2 = strDict2[character.Key];
                    //Console.WriteLine("common key of strDict2: " + commonCharCount2);//returns the value of the key
                    //Console.WriteLine("commonChar difference: " + Math.Abs(commonCharCount1 - commonCharCount2));
                    minDeletions = Math.Abs(commonCharCount1 - commonCharCount2) + minDeletions;
                    
                }
           }
            return minDeletions;
            
        }
    }
}
