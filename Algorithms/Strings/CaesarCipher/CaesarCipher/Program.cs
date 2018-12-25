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
        }

        // Complete the caesarCipher function below.
        static string caesarCipher(string s, int k)
        {
            char ch = ' ';
            int number = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    //byte[] asciiBytes = Encoding.ASCII.GetBytes(s[i]);
                    //foreach (byte b in System.Text.Encoding.UTF8.GetBytes(s.ToCharArray()))
                    // Console.Write(b.ToString());
                    ch = s[i];
                    number = (int)ch;
                    Console.WriteLine(number);

                }
            }
            return "";

        }

    }
}
