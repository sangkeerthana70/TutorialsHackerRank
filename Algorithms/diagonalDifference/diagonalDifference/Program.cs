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
            int n = arr.GetLength(0);
            int m = n;

            //calculate the sum of left-to-right diagonals
            for (int i = 0; i < n; i++)
            {
                m = i;
                for (int j = 0; j < n; j++)
                {
                    if (j == m)
                    {
                        lToRDiagDiff += arr[i][j];
                    }
                }
            }

            // rest m to size of the matrix
            m = n;
            // calculate the sum of right-to-left diagonals
            for (int i = 0; i < n; i++)
            {
                m = m - 1;

                for (int j = 0; j < n; j++)
                {
                    if (j == m)
                    {
                        rToLDiagDiff += arr[i][j];
                    }

                }
            }

            // calculate the absolute difference of both diagnols
            diagonalDifference = Math.Abs(lToRDiagDiff - rToLDiagDiff);

            return diagonalDifference;

        }
    }
}
