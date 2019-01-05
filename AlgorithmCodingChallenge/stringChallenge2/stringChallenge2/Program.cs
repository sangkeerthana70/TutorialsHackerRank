using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "bear";
            //string b = "that";
            string b = "this";
            int length = 4;
            

            int[] result = FindDifferenceBetweenTwoStrings(a, b, length);

        }

        public static int[] FindDifferenceBetweenTwoStrings(string a, string b, int length)
        {
            int[] arr = new int[length];
            int difference;
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine("a[i] " + a[i]);
                Console.WriteLine("b[j] " + b[i]);
                if(a[i] == b[i])
                {
                    difference = 0;
                    Console.WriteLine("difference " + difference);
                    arr[i] = difference;

                }
                else
                {
                    Console.WriteLine("a[i] " + a[i]);
                    Console.WriteLine("b[j] " + b[i]);
                    int castCharOfa = (int)a[i];
                    Console.WriteLine("cast a " + a[i] + castCharOfa);
                    int castCharOfb = (int)b[i];
                    Console.WriteLine(("cast b " + b[i] + castCharOfb));
                    difference = castCharOfb - castCharOfa;
                    Console.WriteLine("difference " + difference);
                    arr[i] = difference;
                }
            }
            //foreach(int item in arr)
            //{
            //    Console.Write(item + " ");
            //}

            Console.WriteLine(string.Join(" ", arr));
            return arr;

        }
    }
}
