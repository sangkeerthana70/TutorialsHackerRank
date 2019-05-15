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
            int pageViewNumber = p / 2;
            Console.WriteLine("pageViewNum : " + pageViewNumber);
            int lastPage = n / 2;
            Console.WriteLine("lastpage: " + lastPage);
            int flipFromBegining = pageViewNumber;
            Console.WriteLine("flip from start: " + flipFromBegining);
            int flipFromEnd = lastPage - pageViewNumber;
            Console.WriteLine("flip from end: " + flipFromBegining);
            if(flipFromBegining < flipFromEnd)
            {
                return flipFromBegining;
            }
            return flipFromEnd;
        }
    }
}
