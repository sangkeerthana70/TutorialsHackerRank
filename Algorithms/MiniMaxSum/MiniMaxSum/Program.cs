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
            int[] arr = new int[] {1, 2, 3, 4, 5};
            miniMaxSum(arr);
        }

        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            long sumMin = 0;
            long sumMax = 0;

            Array.Sort(arr);
            for (int num = arr[0]; num <= arr.Length - 1; num++)
            {
                Console.WriteLine("First elem in arr: " + arr[0]);
                Console.WriteLine(num);
                Console.WriteLine("Fourth elem: " + arr[4]);
                if (arr[num] == arr[4])
                {
                    break;
                }
                sumMin = arr[num] + arr[num + 1];
                
            }
            Console.WriteLine("Second element: " + arr[1]);
            Console.WriteLine("ARR Len: " + arr.Length);
            for (int i = arr[1]; i <= arr.Length; i++)
            {
                Console.WriteLine("Second elem in arr: " + arr[1]);
                
                if (arr[i] == arr[4])
                {
                    //sumMax = arr[i];
                    break;
                }
                sumMax = arr[i] + arr[i + 1];
            }
            Console.WriteLine("Sum of Min: " + sumMin);
            Console.WriteLine("Sum of Max: " + sumMax);            

        }

    }
}
