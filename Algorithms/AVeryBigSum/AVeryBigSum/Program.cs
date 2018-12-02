using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            long[] ar = new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            long sum = aVeryBigSum(ar);
            
        }

        // Complete the aVeryBigSum function below.
        static long aVeryBigSum(long[] ar)
        {
            long sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            Console.WriteLine(sum);
            return sum;


        }
    }
}
