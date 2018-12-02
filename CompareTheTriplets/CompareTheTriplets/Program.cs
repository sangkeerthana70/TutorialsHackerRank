using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int> {5, 6, 7 };
            List<int> b = new List<int> {3, 6, 10 };
            var result = compareTriplets(a, b);
            Console.WriteLine(result);
            

        }

        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int pointForAlice = 0;
            int pointForBob = 0;
            int noPointsForBoth = 0;
            List <int> result = new List<int>();
            if (a[0] > b[0])
            {
                pointForAlice += 1;
            }
            else if(a[0] < b[0] )
            {
                pointForBob += 1;
            }
            else
            {
                noPointsForBoth = 0;
            }

            if (a[1] > b[1])
            {
                pointForAlice += 1;
            }
            else if (a[1] < b[1])
            {
                pointForBob += 1;
            }
            else
            {
                noPointsForBoth = 0;
            }

            if (a[2] > b[2])
            {
                pointForAlice += 1;
            }
            else if (a[2] < b[2])
            {
                pointForBob += 1;
            }
            else
            {
                noPointsForBoth = 0;
            }



            result.Add(pointForAlice);
            result.Add(pointForBob);
            
            foreach(int item in result)
            {
                Console.WriteLine(item);
            }
            return result;
       

        }

    }
}
