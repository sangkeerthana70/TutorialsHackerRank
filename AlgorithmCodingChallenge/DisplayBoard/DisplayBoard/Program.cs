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
            Console.WriteLine("Simple 5X5 tictac toe board");
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
            
            Console.WriteLine();
            Console.WriteLine("Print 5x5 board by calling a static function PrintTicTacToeBoard()");            
            PrintTicTacToeBoard();        
            // call the Approach2 class
            Console.WriteLine();
            PrintTicTacToeApproach2 method2 = new PrintTicTacToeApproach2(5);
            Console.WriteLine("Call class ");
            method2.DrawTicTacToeBoard(15);
            Console.WriteLine();


        }

        public static void PrintTicTacToeBoard()
        {
            Console.WriteLine();
            int height = 5;
            for(int i = 0; i < height; i++)
            {
                if(i == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(" | | ");
                }
                
                
                for (int j = 0; j < height - 4; j++)
                {                   
                        Console.WriteLine("-+-+-");
                }
               
            }
            // print the last row out of the loop
            Console.WriteLine(" | | ");

        }

        
        
    }
}
