using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayBoard
{
    public class PrintTicTacToeApproach2
    {
        int height;
        public PrintTicTacToeApproach2(int h)
        {
            this.height = h;
        }


        public void DrawTicTacToeBoard( int height)
        {
             
            for (int i = 0; i < height; i++)
            {
                if (i % 2 == 0)
                {                   
                    for (int j = 0; j < height; j++)
                    {
                        Console.Write(" | ");
                    }
                }
                else
                {                  
                    for (int k = 0; k < height; k++)
                    {
                        Console.Write("-+-");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
