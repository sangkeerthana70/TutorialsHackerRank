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
            int[] scores = { 12, 24, 10, 24 };
            int[] result = breakingRecords(scores);
        }

        // Complete the breakingRecords function below.
        static int[] breakingRecords(int[] scores)
        {
            int mostScoreCount = 0;
            int leastScoreCount = 0;
            int maxValue = int.MinValue;
            Console.WriteLine(maxValue);
            int minValue = int.MaxValue;
            Console.WriteLine("int.MaxValue: " + minValue);
            for (int i = 0; i < scores.Length; i++)
            {
                int score = scores[i];
                Console.WriteLine("Curr elem: " + score);
                // max value
                if(score >maxValue)
                {

                    maxValue = score;
                    //Console.WriteLine("MaxValue: " + maxValue);
                }
                // min value
                if(score < minValue)
                {
                    minValue = score;
                    //Console.WriteLine("minValue: " + minValue);
                }
            }
            Console.WriteLine("MaxValue: " + maxValue);
            Console.WriteLine("minValue: " + minValue);
            return scores;

        }

    }

}
