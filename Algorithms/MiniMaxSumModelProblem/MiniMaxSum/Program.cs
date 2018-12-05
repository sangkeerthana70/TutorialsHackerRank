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
            int[] arr = new int[] { 7, 69, 2, 221, 8974 };
            miniMaxSum(arr);
        }

        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            //Console.WriteLine(minValue);
            //Console.WriteLine(maxValue);

            long sumMin = 0;
            long sumMax = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                //find the minimum value
                if (arr[i] < minValue)
                {
                   // Console.WriteLine("curr elem: " + arr[i]);
                    
                    minValue = arr[i];                                        
                }
                
                //find the max value
                if (arr[i] > maxValue)
                {
                    //Console.WriteLine("curr elem: " + arr[i]);
                    
                    maxValue = arr[i];
                    
                }               
            }
            Console.WriteLine("Min value: " + minValue);
            Console.WriteLine("Max value: " + maxValue);

            //after determining min and max get their sum in a separate for loop
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != maxValue)
                {
                    //Console.WriteLine("Min num: " + arr[i]);
                    sumMin += arr[i];
                }

                if (arr[i] != minValue)
                {
                    //Console.WriteLine("Max num: " + arr[i]);
                    sumMax += arr[i];
                }
            }
            Console.WriteLine(sumMin + " " + sumMax);

            //Expected output
            //299 9271


        }

    }
}
