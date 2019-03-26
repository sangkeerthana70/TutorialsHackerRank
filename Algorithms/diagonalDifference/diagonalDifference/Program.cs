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
            int[][] squareMatrix = new int[3][];
            squareMatrix[0] = new int[] { 11, 2, 4 };
            squareMatrix[1] = new int[] { 4, 5, 6 };
            squareMatrix[2] = new int[] { 10, 8, -12 };

            int result = diagonalDifference(squareMatrix);
            Console.WriteLine("diagonalDifference : " + result);
        }

        // Complete the diagonalDifference function below.
        static int diagonalDifference(int[][] arr)
        {
            int lToRDiagDiff = 0;
            int rToLDiagDiff = 0;
            int diagonalDifference = 0;
            
            for(var j = 0; j < arr.GetLength(0); j++)
            {
                int len = arr.GetLength(0);
                //Console.WriteLine("len: " + len);
                //Console.WriteLine("j is: " + j);
                int[] innerArray = arr[j];
                //Console.WriteLine(String.Join(" ", innerArray));
                for(var i = 0; i <= 1; i++)          
                {
                    // to loop through the innerArray only once use this condition
                    if(i == j)
                    {
                        //Console.WriteLine("i is: " + i);
                        //Console.WriteLine("j is: " + j);
                        //Console.WriteLine("arr[j][i]: " + arr[j][i]);
                        lToRDiagDiff = arr[j][i];
                        //Console.WriteLine("arr[j + 1][i + 1]: " + arr[j + 1][i + 1]);
                        lToRDiagDiff += arr[j + 1][i + 1];

                        lToRDiagDiff += arr[j + 2][i + 2];
                        ////Console.WriteLine("arr[j + 2][i + 2]: " + arr[j + 2][i + 2]);
                        Console.WriteLine("lToRDiagDiff: " + lToRDiagDiff);
                        //Console.WriteLine("---------------------------------------------");
                        rToLDiagDiff = arr[j][len -1];
                        //Console.WriteLine("arr[j][len -1]: " + arr[j][len - 1]);
                        rToLDiagDiff += arr[j + 1][i + 1];
                        //Console.WriteLine("arr[j + 1][i + 1]: " + arr[j + 1][i + 1]);
                        rToLDiagDiff += arr[j+2][i];
                        //Console.WriteLine("arr[j+2][i]: " + arr[j+2][i]);
                        //Console.WriteLine("rToLDiagDiff: " + rToLDiagDiff);
                    }
                    else if(i != j)
                    {
                        break;
                    }
                    diagonalDifference = Math.Abs(lToRDiagDiff - rToLDiagDiff);

                   
                    
                }
            }

            return diagonalDifference;
        }
    }
}
