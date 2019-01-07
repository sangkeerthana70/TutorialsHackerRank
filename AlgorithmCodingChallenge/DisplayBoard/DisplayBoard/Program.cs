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

            int rows = 2;
            

            for(int i = 0; i < rows; i++)
            {
                Console.Write(" "); 
                Console.WriteLine("| |" + " ");
                
                for(int j = 0; j < rows - 1; j++)
                {
                    
                    Console.WriteLine("-+-+-");
                }
                

            }
            // print the last row out of the loop
            Console.WriteLine(" | | ");


        }

        

               
           
           


        
    }
}
