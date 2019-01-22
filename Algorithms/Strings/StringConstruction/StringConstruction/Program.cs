using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcd";
            
            int result = stringConstruction(s);
        }

        // Complete the stringConstruction function below.
        static int stringConstruction(string s)
        {
            string p = "";
            int cost = 0;
            StringBuilder sb = new StringBuilder();
 
            sb.Append(s);
            
            p += sb;
            Console.WriteLine("p: " + p);

            for(int i = 0; i < s.Length - 1; i++)
            {
                if(p[i] != p[i + 1])
                {
                   cost += 1;
                }
            }
            Console.WriteLine("cost: " + cost);
            return cost;

        }
    }
}
