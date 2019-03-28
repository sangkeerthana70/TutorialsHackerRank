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
            Dictionary<int, int> birds = new Dictionary<int, int>();
            int maxValue = int.MinValue;
            int refKey = 0;

            for (var i = 0; i < arr.Count; i++)
            {
                if (birds.ContainsKey(arr[i]))
                {
                    // if the key already exists increment its value by 1
                    birds[arr[i]] += 1;
                }
                else
                {
                    birds.Add(arr[i], 1);
                }
                
            }
            foreach(var bird in birds)
            {
                Console.WriteLine("Key = {0} value = {1}", bird.Key, bird.Value);
                // find the maximum value in the dictionary
                if (bird.Value > maxValue)
                {
                    maxValue = bird.Value;
                    refKey = bird.Key;
                    //Console.WriteLine("Key: " + refKey);

                }
            }
            // return the number with the most occurrance
            Console.WriteLine("The most spotted bird is = {0}  ", refKey);
            return refKey;


            
        }
    }
}
