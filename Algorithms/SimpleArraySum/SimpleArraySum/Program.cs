using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArr = 6;
            int[] ar = new int[] { 1, 2, 3, 4, 10, 11 };

            int sum = simpleArraySum(ar);

        }

        static int simpleArraySum(int[] ar)
        {
            int sum = 0;
            for(int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
               
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}
