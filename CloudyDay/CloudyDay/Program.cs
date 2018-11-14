using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] population = new int[] { 1000, 500, 750, 2000, 2500 };
            int[] townLoc = new int[] { 10, 30, 50, 60, 80 };
            int[] cloudLoc = new int[] { 15, 45, 70 };
            int[] cloudRange = new int[] { 6, 10, 5 };

            var result = GetMaxPopulation(population, townLoc, cloudLoc, cloudRange);
            Console.WriteLine(result);
        }

        private static object GetMaxPopulation(int[] population, int[] townLoc, int[] cloudLoc, int[] cloudRange)
        {
            throw new NotImplementedException();
        }
    }
}