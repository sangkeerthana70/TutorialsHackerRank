using System;

namespace SockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int n = 9;
            int[] ar = new[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
            SockMerchant(n, ar);
        }

        static int SockMerchant(int n, int[] ar)
        {
            int pairSock = 0;

            Array.Sort(ar);
           

            for (int i = 0; i < ar.Length -1 ; i++)
            {
                Console.WriteLine("Loop: " + i);
                if(ar[i] == ar[i + 1])
                {
                    Console.WriteLine("Sock color:" + ar[i] );
                   
                    Console.WriteLine("Found a match" + ar[i+1]);
                    pairSock += 1;
                    i++;
                }
                
                
            }
            Console.WriteLine("Total Number of pairs :" + pairSock);
            return pairSock;


        }
    }
}
