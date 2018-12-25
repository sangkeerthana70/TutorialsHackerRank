using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstIndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 25, 21, 3, 25, 7};
            int val = 25;
            int result = FindIndexOfVal(arr, val);
            Console.WriteLine("result : " + result);

        }

        public static int FindIndexOfVal(int[] arr, int val)
        {
            //int i = 0;
            //for (i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == val)
            //    {
            //        Console.WriteLine("found a match");
            //        Console.WriteLine("arr[i]" + arr[i]);
            //        Console.WriteLine("i : " + i);
            //        return i;
            //    }
            //    //Console.WriteLine("i in loop: " + i);

            //}

            ////Console.WriteLine("i: " + i);
            //return -1;

            bool foundIndex = false;
            int i = 0;
            for(i = 0; i < arr.Length; i++)
            {
                if (arr[i] == val)
                {
                    Console.WriteLine("found a match");
                    foundIndex = true;
                    break;
                }
                
            }
            if(foundIndex == true)
            {
                return i;
            }
            else
            {
                return -1;
            }
           
        }
    }
}
