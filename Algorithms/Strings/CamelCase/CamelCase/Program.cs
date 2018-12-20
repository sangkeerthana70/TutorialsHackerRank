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
                

                if (Char.IsUpper(s[i]))
                {

                    wordCount ++;
                }
                //else
                //{
                //    Console.WriteLine("char is lower case");
                    
                //}

            }
            Console.WriteLine("Word count: " + wordCount);
            return wordCount;

        }

 
    }
}
