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
            int[] scores = { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };
            int[] result = breakingRecords(scores);
        }

        // Complete the breakingRecords function below.
        static int[] breakingRecords(int[] scores)
        {
            int[] result = new int[] { }; 
            int mostScoreCount = -1;
            int leastScoreCount = -1;
            
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
                
                if( score < minValue)
                {
                    //Console.WriteLine("i is: " + i);
                    minValue = score;
                    
                    Console.WriteLine("leastScore " + minValue);
                    
                    leastScoreCount += 1;
                    Console.WriteLine("leastScoreCount " + leastScoreCount);
                }

            }

            Console.WriteLine(string.Join(" ", mostScoreCount, leastScoreCount));
            
            return result;

        }

    }

}
