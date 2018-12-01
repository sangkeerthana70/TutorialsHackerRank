using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCandles = 4;
            int[] ar = new int[] { 3, 2, 1, 3 };
            var result = birthdayCakeCandles(ar);
            Console.WriteLine(result);

        }

        
        static int birthdayCakeCandles(int[] ar)
        {
            int tallCandle = 0;
            int totalBlown = 0;

            for (int i = 0; i < ar.Length; i++){
                Console.WriteLine("Loop: " , i);
                Console.WriteLine("Curr Elem: " , ar[i]);
                if (ar[i] > tallCandle  )
                {
                    tallCandle = ar[i];
                    totalBlown += 1;
                    Console.WriteLine("Array elem is greater than counter");
                }
                else if (ar[i] ==  tallCandle)
                {
                    totalBlown += 1;
                }               

            }
            return totalBlown;

        }
    }
}
