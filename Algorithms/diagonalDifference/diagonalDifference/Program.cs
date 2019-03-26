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

            for (var i = 0; i <= len -1; i++)
            {
                
                Console.WriteLine("len: " + len);
                Console.WriteLine("i is: " + i);
                int[] innerArray = arr[i];
                Console.WriteLine(String.Join(" ", innerArray));
                for(var j = 0; j <= innerArray.Length; j++)          
                {
                    // to loop through the innerArray only once use this condition
                    if(i == j)
                    {
                        Console.WriteLine("i is: " + i);
                        Console.WriteLine("j is: " + j);
                        lToRDiagDiff = arr[i][j];
                        //Console.WriteLine(arr[i][j]);
                        lToRDiagDiff += arr[i + 1][j + 1];
                        //Console.WriteLine(arr[i + 1][j + 1]);
                        lToRDiagDiff += arr[i + 2][j + 2];                       
                        //Console.WriteLine(arr[i + 2][j + 2]);
                        lToRDiagDiff += arr[i + 3][j + 3];
                        //Console.WriteLine(arr[i + 3][j + 3]);
                        Console.WriteLine(lToRDiagDiff);
                        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx");
                        rToLDiagDiff = arr[i][len-1];
                        Console.WriteLine("ll" + arr[i][len-1]);
                        rToLDiagDiff += arr[i + 1][len - 2];
                        Console.WriteLine(arr[i + 1][len - 2]);
                        rToLDiagDiff += arr[i + 2][len - 3];
                        Console.WriteLine(arr[i + 2][len - 3]);
                        rToLDiagDiff += arr[i + 3][len - 4];
                        Console.WriteLine(arr[i + 3][len - 4]);
                        Console.WriteLine(rToLDiagDiff);
                    }
                    else if(i != j)
                    {
                        break;
                    }                   
                }
                diagonalDifference = Math.Abs(lToRDiagDiff - rToLDiagDiff);
            }

            return diagonalDifference;
        }
    }
}
