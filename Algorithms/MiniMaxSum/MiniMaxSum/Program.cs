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
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine("i : " + i);
                Console.WriteLine("arr[i] : " + arr[i]);
               
                sumMin += arr[i];
                Console.WriteLine("sumMin : " + sumMin);
                
            }
            
            for (int i = 1; i < arr.Length; i++)
            {
                Console.WriteLine("i : " + i);
                Console.WriteLine("arr[i] : " + arr[i]);

                sumMax += arr[i];
                Console.WriteLine("SumMax: " +  sumMax);
            }
            Console.WriteLine(sumMin + " " + sumMax);
                        

        }

    }
}
