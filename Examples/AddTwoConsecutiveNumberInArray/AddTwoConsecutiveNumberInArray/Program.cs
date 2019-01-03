using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoConsecutiveNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 3, 2, 1, 5, 4 };
            

            int[] result = SumTwoConsecutiveNumsInArr(arr1);

            

        }

        public static int[] SumTwoConsecutiveNumsInArr(int [] arr1)
        {
            int[] arr2 = new int[] { };
            int sumTwoNums = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr1.Length - 1)
                {
                    sumTwoNums = arr1[i];
                    Console.WriteLine("sum " + sumTwoNums);
                }
                //if(arr1[i] == arr1.Length)
                //{
                //    sumTwoNums = arr1[0] + arr1[i];
                //}
                else
                {
                    sumTwoNums = arr1[i] + arr1[i + 1];
                    Console.WriteLine("sum " + sumTwoNums);

                }
                //arr2[i] = (sumTwoNums);

            }
            return arr2;
            
        }

            
    }
}
