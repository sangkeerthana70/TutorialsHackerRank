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
            /*
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
            */

            //------------------------------------------------------------
            int[] gameCode = new int[4] { 1, 2, 3, 4 };
            int input = 4321;
            int[] result = CalculateScore(gameCode, input);
        }

        // program to calculate scores for correct number and position from a guess that is inputed
        public static int [] CalculateScore(int [] gameCode, int input)
        {
            int[] result = new int[2];
            int CorrectNumbers = 0;
            int CorrectPositions = 0;
            //convert the input variable to a string
            string s = input.ToString();
            Console.WriteLine("s: " + s);
            int currNum;
            for(var i = 0; i < s.Length; i++)
            {
                Console.WriteLine("s[i] = " + s[i]);
                currNum = Convert.ToInt32(s[i]) - 48;// 48 represents ascii of 0
                Console.WriteLine("currNum =" + currNum);
                for (var j = 0; j < gameCode.Length; j++)
                {
                    Console.WriteLine("gameCode[j] " + gameCode[j]);
                    if(currNum == gameCode[j])
                    {
                        Console.WriteLine("Number matched");
                        CorrectNumbers += 1;
                        // check position of both numbers
                        if(i == j)
                        {
                            Console.WriteLine("Position matched");
                            CorrectPositions += 1;
                        }
                        break;

                    }
                }
                result[0] = CorrectNumbers;
                result[1] = CorrectPositions;
            }
            Console.WriteLine(string.Join(" ", CorrectNumbers, CorrectPositions));
            return result;
        }
        




    }
}
