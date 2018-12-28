using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "SOSSOT";
            int result = marsExploration(s);
        }

        // Complete the marsExploration function below.
        static int marsExploration(string s)
        {
            //string expectedSignal = "SOS";
            //int messagesSent = s.Length / 3;
            //StringBuilder replicateExpectedSignal = new StringBuilder();
            int misMatch = 0;
            char oddChar = 'O';
            char evenChar = 'S';
            

            for (int i = 0; i < s.Length; i++)
            {

                int j = i % 3;
                // s[0] = 'S'
                if ((j == 0) && (s[i] != 'S')) misMatch++;
                // s[1] = 'O'
                if ((j == 1) && (s[i] != 'O')) misMatch++;
                // s[2] = 'S'
                if ((j == 2) && (s[i] != 'S')) misMatch++;

                //if ((j == 0) && (s[i] != 'S'))
                //{
                //    Console.WriteLine("i : " + i);
                //    //Console.WriteLine("even char: " + i % 2);
                //    Console.WriteLine("s[i] : " + s[i]);
                //    if(s[i] != evenChar)
                //    {
                        
                //        misMatch += 1;
                //    }
                    
                //}
                //else if ((j == 1) && (s[i] != 'J'))
                //{
                //    Console.WriteLine("i : " + i);
                //    //Console.WriteLine("odd char: " + i % 2);
                //    Console.WriteLine("s[i] : " + s[i]);
                //    if (s[i] != oddChar)
                //    {
                        
                //        misMatch += 1;
                //    }
                    
                //}
                //else
                //{
                //    misMatch = 0;
                //}
                Console.WriteLine("Mismatch = " + misMatch);

            }
            
            return misMatch;



        }
    }
}
