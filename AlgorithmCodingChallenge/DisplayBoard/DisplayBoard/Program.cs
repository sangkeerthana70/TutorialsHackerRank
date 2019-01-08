using DisplayBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoard
{
    class Program
    {
        static void Main(string[] args)
        {

            //for(int i = 0; i < 3; i++)
            //{
            //     Console.Write(" ");
            //     Console.WriteLine("| |");
            //     Console.WriteLine("-+-+-");
            //}


            // Program to print 5 rows and 5 columns of tic-tac-toe board
            int rows = 2;
            for(int i = 0; i < rows; i++)
            {
                Console.Write("o"); 
                Console.WriteLine("|x|" + "o");
                
                for(int j = 0; j < rows - 1; j++)
                {
                    
                    Console.WriteLine("-+-+-");
                }
            }
            // print the last row out of the loop
            Console.WriteLine("o|x|o");

           
            //PrintTicTacToeBoard();

            // call the Approach2 class
            PrintTicTacToeApproach2 method2 = new PrintTicTacToeApproach2(3, 3);
            for(int i = 0; i < 2; i++)
            {
                method2.printRows();
                for(int j = 0; j < 2 - 1; j++)
                {
                    method2.printColumns();
                }
                
            }
            Console.WriteLine(" | | ");


        }

        public static void PrintTicTacToeBoard()
        {
            Console.WriteLine();
            int height = 2;
            for(int i = 0; i < height; i++)
            {
                
                Console.WriteLine("o|x|o");
                for (int j = 0; j < height - 1; j++)
                {
                    Console.WriteLine("-+-+-");


                }
               
            }
            Console.WriteLine("o|x|o");

        }

        
        
    }
}
