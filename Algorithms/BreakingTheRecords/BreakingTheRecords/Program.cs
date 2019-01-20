using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingTheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
            int[] result = breakingRecords(scores);
        }

        // Complete the breakingRecords function below.
        static int[] breakingRecords(int[] scores)
        {
            int mostScoreCount = -1;
            int leastScoreCount = 0;
            int mostScore = 0;
            int leastScore = 0;
            int maxValue = int.MinValue;
            
            //Console.WriteLine(maxValue);
            int minValue = int.MaxValue;
            //Console.WriteLine("int.MaxValue: " + minValue);
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("i is: " + i);
                int score = scores[i];
                Console.WriteLine("Curr elem: " + score);
                if(score > maxValue)
                {
                    
                    maxValue = score;
                    Console.WriteLine("mostScore " + maxValue);
                    mostScoreCount += 1;
                    Console.WriteLine("mostScoreCount " + mostScoreCount);
                }
                

            }
            Console.WriteLine(string.Join(" ", maxValue));
            return scores;

        }

    }

}
