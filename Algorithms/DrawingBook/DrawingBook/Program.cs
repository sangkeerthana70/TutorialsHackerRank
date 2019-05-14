using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int p = 2;
            int result = pageCount(n, p);
            Console.WriteLine("result: " + result);
        }
            
        //Complete the pageCount function below.      
        static int pageCount(int n, int p)
        {
            /*
            int pageNumber = 1;
            int pageTurns = 0;
            while(pageNumber < p)
            {
                if (pageNumber == p)
                {
                    break;
                }
                pageNumber++;
                Console.WriteLine("pageNumber: " + pageNumber);
                pageTurns++;
                Console.WriteLine("pageTurns: " + pageTurns);
                if()
            }
            return pageTurns;
            */

            int total = n / 2;
            Console.WriteLine("total " + total);
            int right = p / 2;
            Console.WriteLine("right " + right);
            int left = total - right;
            Console.WriteLine("left " + left);

            if (left < right)
                return left;
            else
                return right;
        }
    }
}
