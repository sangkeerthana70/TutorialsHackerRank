using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {5, 5, 5, 5, 5};
            miniMaxSum(arr);
        }

        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            long sumMin = 0;
            long sumMax = 0;

            Array.Sort(arr);
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.WriteLine("First elem in arr: " + arr[0]);
                //Console.WriteLine("i is: " + i);
                Console.WriteLine("Fourth elem: " + arr[3]);
                if (arr[i] == arr[4])
                {
                    break;
                }
                
                sumMin += arr[i];
                Console.WriteLine("SumMin in loop: " +  i + sumMin);
                
            }
            //Console.WriteLine("Second element: " + arr[1]);
            //Console.WriteLine("ARR Len: " + arr.Length);
            for (int i = 1; i <= arr.Length; i++)
            {
                Console.WriteLine("Second elem in arr: " + arr[1]);
                
                if (arr[i] == arr[4])
                {
                    sumMax += arr[4];
                    break;
                }
                //Console.WriteLine("arr[i]: " + arr[i]);
                sumMax += arr[i];
                Console.WriteLine("SumMax in loop: " + i + sumMax);
            }
            Console.WriteLine(sumMin + " " + sumMax);
                        

        }

    }
}
