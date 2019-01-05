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
            string b = "this";
            int length = 4;
            // Function to compare characters in two strings and return the difference between the two character
            //in each string or in other words the number of steps each character must take to become the character of the other string.
            // Eg:ascii value of i in second string 'this' is 8 steps away from a in first string 'bear' which is 105 - 97
            int[] result = FindDifferenceBetweenTwoStrings(a, b, length);

        }

        public static int[] FindDifferenceBetweenTwoStrings(string a, string b, int length)
        {
            int[] arr = new int[length];
            int difference;
            int totChangeScore = 0;
            for(int i = 0; i < length; i++)
            {
                //Console.WriteLine("a[i] " + a[i]);
                //Console.WriteLine("b[j] " + b[i]);
                if(a[i] == b[i])
                {
                    difference = 0;                   
                    arr[i] = difference;

                }
                else
                {                   
                    int castCharOfa = (int)a[i];
                    //Console.WriteLine("cast a " + a[i] + castCharOfa);
                    int castCharOfb = (int)b[i];
                    //Console.WriteLine(("cast b " + b[i] + castCharOfb));
                    difference = castCharOfb - castCharOfa;
                    //Console.WriteLine("difference " + difference);
                    totChangeScore += difference;
                    arr[i] = difference;
                    
                }
            }
            //foreach(int item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            Console.WriteLine("total change score " + totChangeScore);
            Console.WriteLine(string.Join(" ", arr));
            return arr;

        }
    }
}
