using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperReducedString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "aaabccddd";
            //string s = "baab";
            //string s = "aa";
            string s = "mellow";
            string result1 = superReducedString(s);
        }

        // Complete the superReducedString function below.
        static string superReducedString(string s)
        {
            string newString = "";
            bool seen = false;

            // add a while loop to check the final reduced string for same characters
            while (true)
            {
                seen = false;
                for (int i = 0; i < s.Length; i++)
                {
                    //Console.WriteLine("Loop count: " + i);
                    //Console.WriteLine("length - 1 is " + (s.Length - 1));
                    if (i == s.Length - 1)
                    {
                        break;
                    }
                    else
                    {
                        if (s[i] == s[i + 1])
                        {
                            seen = true;
                            newString = System.Convert.ToString(s[i]) + System.Convert.ToString(s[i + 1]);
                            s = s.Replace(newString, "");
                            //s = s.Replace(newString, "");
                            if (s.Length == 0)
                            {
                                s = "Empty String";
                            }
                        }

                    }

                }
                if (!seen)
                {
                    break;
                }

            }

            Console.WriteLine(s);
            return s;
        }
    }

}

