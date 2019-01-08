using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayBoard
{
    public class PrintTicTacToeApproach2
    {       
        int rows;
        int columns;
        public PrintTicTacToeApproach2(int r, int c)
        {
            this.rows = r;
            this.columns = c;
        }


        public void printRows()
        {       
                Console.WriteLine(" | | ");
        }
        public void printColumns()
        {
                Console.WriteLine("-+-+-");
        }
    }
}
