﻿using System;
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
            //Console.WriteLine("n: " + n);
            int m = n;
            //Console.WriteLine("m is: " + m);

            // print the elements in the matrix
            for (int i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                    Console.Write("{0}  ", arr[i][j]);
                Console.Write("\n");
            }

            //calculate the sum of left-to-right diagonals
            for(int i = 0; i < n; i++)
            {
                //Console.WriteLine("i is: " + i);
                
                m = i;
                Console.WriteLine("m is: " + m);
                for(int j = 0; j < n; j++)
                {
                    //Console.WriteLine("j before: " + j);
                    if(j == m)
                    {
                        //Console.WriteLine("j after: " + j);
                        //Console.WriteLine(arr[i][j]);
                        lToRDiagDiff += arr[i][j];
                        Console.WriteLine("ltoR: " + lToRDiagDiff);
                    }
                }
            }
            Console.Write("Addition of the  left-to-right Diagonal elements is :{0}\n", lToRDiagDiff);


            Console.WriteLine("=================================================================");

            // rest m to size of the matrix
            m = n;
            // calculate the sum of right-to-left diagonals
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine("i is: " + i);
                
                m = m - 1;
                Console.WriteLine("m: " + m);
                for (int j = 0; j < n; j++)
                {
                    //Console.WriteLine("j before: " + j);
                    if (j == m)
                    {
                        Console.WriteLine("j after: " + j);
                        Console.WriteLine("arr[i][j]: " + arr[i][j]);
                        rToLDiagDiff += arr[i][j];
                        Console.WriteLine("sum: " + rToLDiagDiff);
                    }

                }
            }
            
            Console.Write("Addition of the  right-to-left Diagonal elements is :{0}\n", rToLDiagDiff);

            // calculate the absolute difference of both diagnols
            diagonalDifference = Math.Abs(lToRDiagDiff - rToLDiagDiff);

            return diagonalDifference;
        }
    }
}
