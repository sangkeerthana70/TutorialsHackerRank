using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "middle - Outz";
            int k = 2;
            string result = caesarCipher(s, k);
            Console.WriteLine(result);
        }

        // Complete the caesarCipher function below.
        static string caesarCipher(string s, int k)
        {
            char ch = ' ';
            int number = 0;
            int alphaIndex = 0;
            int result = 0;
            string cipherString = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    
                    ch = s[i];
                    number = (int)ch;
                    //Console.WriteLine("Char to int: " + number);

                    if (Char.IsUpper(s[i]))
                    {
                        alphaIndex = number - 'A';
                        //Console.WriteLine("alphaIndex: " + alphaIndex);
                        result = ((alphaIndex + k) % 26) + 'A';
                        //Console.WriteLine("Result: " + result);
                        ch = (char)result;
                        //Console.WriteLine("char: " + ch);
                       

                    }
                    else
                    {
                        alphaIndex = number - 'a';
                        //Console.WriteLine("alphaIndex: " + alphaIndex);
                        result = ((alphaIndex + k) % 26) + 'a';
                        //Console.WriteLine("result: " + result);
                        ch = (char)result;
                        //Console.WriteLine("char: " + ch);
                        
                    }
 
                }
                else
                {
                    ch = s[i];
                    
                    //Console.WriteLine(ch);
                }
                cipherString += ch.ToString();

                //Console.Write("cipherString: " + cipherString);
                //Console.WriteLine();
            }
            return cipherString;

        }

    }
}
