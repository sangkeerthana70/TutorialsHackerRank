using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomCode = new int[4];
            Random random = new Random();
            for (var i = 0; i < 4; i++)
            {
                randomCode[i] = random.Next(1,7);
            }

            foreach (var item in randomCode)
            {
                Console.WriteLine(item);
            }

            //int guess = 0;
            //int score = 0;
            //int g;
            //while (guess != 6)
            //{
            //    Console.WriteLine("Guess a number between 1 and 5");
            //    g = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(g);

            //    guess = g;
            //    if (guess == 1)
            //    {
            //        score += 1;
            //    }
            //    else if(guess == 2)
            //    {
            //        score += 1;
            //    }
            //    else if(guess == 3)
            //    {
            //        score += 1;
            //    }
            //    else{
            //        score += 1;
            //    }
            //    Console.WriteLine("score: " + score);
            //}
            
        }
    }
}
