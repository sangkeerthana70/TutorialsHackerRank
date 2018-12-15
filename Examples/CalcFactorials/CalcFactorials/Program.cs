using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 12;
            int result = getFactors(num);
        }

        public static int  getFactors(int num)
        {// returns all factorials.
            //var factors = [];
            int[] factors = new int[] { };
            for (var i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    factors.push(i);
                }
            }
            return factors;
        }
    }
}
