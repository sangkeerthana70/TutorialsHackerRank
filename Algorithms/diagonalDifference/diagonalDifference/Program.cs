using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] squareMatrix = new int[4][];
            squareMatrix[0] = new int[] { -1, 1, - 7, - 8 };
            squareMatrix[1] = new int[] { -10, - 8, - 5, - 2 };
            squareMatrix[2] = new int[] { 0, 9, 7, - 1 };
            squareMatrix[3] = new int[] { 4, 4, - 2, 1 };

            int result = diagonalDifference(squareMatrix);
            Console.WriteLine("diagonalDifference : " + result);
        }

        // Complete the diagonalDifference function below.
        static int diagonalDifference(int[][] arr)
        {
            int lToRDiagDiff = 0;
            int rToLDiagDiff = 0;
            int diagonalDifference = 0;
            int len = arr.GetLength(0);
            


            for (int i = 0; i < len -1; i++)
            {
                if (i > 0)
                {
                    break;
                }
                int[] innerArray = arr[i];
                int row = arr.GetLength(0);
                Console.WriteLine("rows: " + row);
                int col = innerArray.Length;
                Console.WriteLine("columns: " + col);

                for (var j = 0; j < innerArray.Length; j++)
                {
                    if(j > 0)
                    {
                        break;
                    }
                    
                    lToRDiagDiff = arr[i][j];
                    Console.WriteLine(arr[i][j]);
                    Console.WriteLine(arr[row-3][col-3]);
                    Console.WriteLine(arr[row - 2][col-2]);
                    Console.WriteLine(arr[row-1][col-1]);
                    lToRDiagDiff += arr[row - 3][col - 3];
                    lToRDiagDiff += arr[row - 2][col - 2];
                    lToRDiagDiff += arr[row - 1][col - 1];
                    Console.WriteLine(lToRDiagDiff);
                    Console.WriteLine("+++++++=======================================");
                    rToLDiagDiff = arr[i][col - 1];
                    //Console.WriteLine(arr[i][col-1]);                    
                    //Console.WriteLine(arr[row-3][col-2]);
                    //Console.WriteLine(arr[row-2][col-3]);
                    //Console.WriteLine(arr[row-1][col-4]);
                    rToLDiagDiff += arr[row - 3][col - 2];
                    rToLDiagDiff += arr[row - 2][col - 3];
                    rToLDiagDiff += arr[row - 1][col - 4];
                    Console.WriteLine(rToLDiagDiff);

                }

                diagonalDifference = Math.Abs(lToRDiagDiff - rToLDiagDiff);
                    
                
                
            }

            return diagonalDifference;

        }
    }
}
