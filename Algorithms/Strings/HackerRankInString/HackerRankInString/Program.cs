using System;

using System.Text;
using System.Threading.Tasks;


namespace HackerRankInString
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = 2;
            string s = "buterfly";
          

            string result = hackerrankInString(s);
            Console.WriteLine("RESULT: " + result);
        }

        // Complete the hackerrankInString function below.
        static string hackerrankInString(string s)
        {
            string toCheck = "butt";

            string finalCheck = "";
            //bool firstOccurrance = false;

            for(int i = 0; i < toCheck.Length; i++)
            {
                //Console.WriteLine("outer loop: " + s[i]);
                for (int j = 0; j < s.Length; j++)
                {
                    Console.WriteLine(toCheck[i]);
                    Console.WriteLine(s[j]);
                    if(toCheck[i] == s[j])
                    {
                        finalCheck += s[j];
                        Console.WriteLine(finalCheck);
                        break;
                    }                    
                    
                }
                if (finalCheck.Contains("butt"))
                {
                    return "YES";
                }
            }
            
            return "NO";

        }

    }
}
