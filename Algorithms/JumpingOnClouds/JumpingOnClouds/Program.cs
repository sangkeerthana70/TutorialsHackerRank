using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cloudArray = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            FindNumberOfCloudsJumped(cloudArray);
        }

        static int FindNumberOfCloudsJumped(int[] cloudArray)
        {
            int counter = 0;
            for(int i = 0; i < cloudArray.Length -1; i++)
            {
                if(cloudArray[i] == 0)
                {
                    if(cloudArray[i + 1] == 0)
                    {
                        counter += 1;
                        continue;
                    }
                    else
                    {
                        counter = 0;
                        continue;
                    }
                }
            }
            Console.WriteLine("counter check: " + counter);
            return counter;
        }
    }
}
