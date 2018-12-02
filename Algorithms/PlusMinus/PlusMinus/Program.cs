using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArr = 6;
            int[] arr = new int[] { -4, 3, - 9, 0, 4, 1 };
            plusMinus(arr);
        }

        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            float totalPositiveElem = 0;
            float totalNegativeElem = 0;
            float numberOfZeros = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    totalPositiveElem += 1;
                }
                if (arr[i] < 0)
                {
                    totalNegativeElem += 1;
                }
                if(arr[i] == 0)
                {
                    numberOfZeros += 1;
                }
            }
            //Console.WriteLine(totalPositiveElem);
            //Console.WriteLine(totalNegativeElem);
           //Console.WriteLine(numberOfZeros);

            float positives = (totalPositiveElem / arr.Length);
            Console.WriteLine("Fraction of positives " + positives);
            float negatives = totalNegativeElem / arr.Length;
            Console.WriteLine("Fraction of negatives " + negatives);
            float zeros = numberOfZeros / arr.Length;
            Console.WriteLine("Fraction of Zeros " + zeros);
        }

    }
}
