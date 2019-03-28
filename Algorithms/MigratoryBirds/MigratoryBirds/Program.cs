using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 1, 4, 4, 4, 5, 3 };
            int result = migratoryBirds(arr);
        }

        // Complete the migratoryBirds function below.
        static int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> birdCount = new Dictionary<int, int>();
            for (var i = 0; i < arr.Count; i++)
            {
                
                birdCount.Add(arr[i], 1);
            }
            

        }
    }
}
