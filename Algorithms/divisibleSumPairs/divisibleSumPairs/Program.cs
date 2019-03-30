using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 7;
            int[] arr = new int[] { 36, 46, 25, 97, 57, 14, 21, 50, 75, 58, 54, 32, 73, 11, 36, 22, 95, 46, 54, 61 };
            int result = divisibleSumPairs(k, arr);
            Console.WriteLine("result: " + result);
        }

        // Complete the divisibleSumPairs function below.
        static int divisibleSumPairs(int k, int[] arr)
        {
            int divisiblePairCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine("i is : " + i);
                //Console.WriteLine("arr[i]: " + arr[i]);
                for(int j = i+1; j < arr.Length; j++)
                {
                    //Console.WriteLine("j is: " + j);
                    //Console.WriteLine("arr[i] and arr[j] : " + arr[i] + " " + arr[j]);
                    if((arr[i] + arr[j]) % k == 0)
                    {
                       // Console.WriteLine("pairs divisible by k: " + arr[i] + " " + arr[j]);
                        divisiblePairCount += 1;
                        //Console.WriteLine("divisiblePairCount: " + divisiblePairCount);
                    }
                }
            }
            return divisiblePairCount;

        }
    }
}
