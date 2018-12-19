using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "saveChangesInTheEditor";
            int result = camelcase(s);
        }

        // Complete the camelcase function below.
        static int camelcase(string s)
        {
            int wordCount = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (IsUpper(s[i]))
                {

                    wordCount += 1;
                }
                else
                {
                    Console.WriteLine("char is lower case");
                    
                }

            }
            Console.WriteLine(wordCount);
            return wordCount;

        }

        //private static bool IsUpper(char v)
        //{
        //    throw new NotImplementedException();

        //}
    }
}
