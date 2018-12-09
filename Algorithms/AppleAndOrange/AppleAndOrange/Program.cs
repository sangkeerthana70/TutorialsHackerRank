using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 7;
            int t = 11;
            int a = 5;//position a
            int b = 15;//position b
            int appCount = 3;
            int orangeCount = 2;
            int[] apples = new int[] { -2, 2, 1 };
            int[] oranges = new int[] { 5, -6 };

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }

        // Complete the countApplesAndOranges function below.
        
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleOnHouse = 0;
            int orangeOnHouse = 0;
            int applesPosition = 0;
            int orangesPosition = 0;

            for (int i = 0; i < apples.Length; i++)
            {
                applesPosition = a + apples[i];
                Console.WriteLine("Position Of apple from tree: " + applesPosition);
                if (applesPosition >= s && applesPosition <= t)
                {
                    appleOnHouse++;
                }
            }
            //Console.WriteLine("Apple count: " + appleOnHouse);

            for (int j = 0; j < oranges.Length; j++)
            {
                orangesPosition = b + oranges[j];
                Console.WriteLine("oranges position from tree: " + orangesPosition);
                if (orangesPosition >= s && orangesPosition <= t)
                {
                    orangeOnHouse++;
                }
            }
            Console.WriteLine("No of app: " + appleOnHouse);
            Console.WriteLine("No of Oranges: " + orangeOnHouse);
        }
    }
}
