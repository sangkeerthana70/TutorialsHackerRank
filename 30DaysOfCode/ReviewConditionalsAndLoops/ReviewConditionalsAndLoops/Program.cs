using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewConditionalsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string S1 = "ivvkxq";
            string S2 = "ivvkx";
            string even1 = "";
            string odd1 = "";
            string even2 = "";
            string odd2 = "";
            //Loop through string S1
            for (int i = 0; i < S1.Length; i++)
            {
                //Console.WriteLine( i + "%2: " + i%2);
                if (i % 2 == 0)
                {

                    //Console.WriteLine(S1[i] + " is even");
                    even1 += S1[i];
                    
                }
                else
                {
                    //Console.WriteLine(S1[i] + " is odd");
                    odd1 += S1[i];
                }
            }

            for (int i = 0; i < S2.Length; i++)
            {
                //Console.WriteLine(i + "%2: " + i % 2);
                if (i % 2 == 0)
                {

                    //Console.WriteLine(S2[i] + " is even");
                    even2 += S2[i];

                }
                else
                {
                    //Console.WriteLine(S2[i] + " is odd");
                    odd2 += S2[i];
                }
            }

            Console.WriteLine(even1 +  " " + odd1);
            Console.WriteLine(even2 + " " + odd2);
        }
    }
}
