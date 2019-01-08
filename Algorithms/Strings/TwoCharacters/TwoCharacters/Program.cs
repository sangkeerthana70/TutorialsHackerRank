using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
 
            //string s = "beabeefeab";
            //int result = alternate(s);

            //string s = "aaabccddd";
            string s = "baab";
            string result1 = superReducedString(s);

        }

        // Complete the alternate function below.
        static int alternate(string s)
        {
            
            return 0;
        }

        // Complete the superReducedString function below.
        static string superReducedString(string s)
        {
            string reducedString = "";
            
            for (int i = 0; i < s.Length; i++)
            {               
                if (i == s.Length - 1)
                {
                    break;

                }
                else
                {
                    if (s[i] == s[i + 1])
                    {
                        Console.WriteLine("same character");
                        //Console.WriteLine("s[i] " + s[i]);
                        //Console.WriteLine("s[i + 1] " + s[i + 1]);
                        reducedString = System.Convert.ToString(s[i]) + System.Convert.ToString(s[i + 1]);
                        //Console.WriteLine("new string " + newString);
                         s = s.Replace(reducedString, "");
                        Console.WriteLine("Reduced string after removing same characters " + s);
                        
                        if (s.Length == 0)
                        {                           
                            s = "Empty String";                           
                        }
                    }                   
                }              
            }
            Console.WriteLine(s);
            return s;
        }

    }
}
