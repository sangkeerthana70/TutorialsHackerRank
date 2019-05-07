using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 60;
            int[] keyBoards = new int[] { 40, 50, 60 };
            int[] usbDrives = new int[] { 5, 8, 12 };

           
            int result = getMoneySpent(keyBoards, usbDrives, input);
            Console.WriteLine("result: " + result);
            
        }

        
        // Complete the getMoneySpent function below.
        
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            //Write your code here.
            int maxValue = -1;
            int cost = 0;
            for(int i = 0; i < keyboards.Length; i++)
            {
                Console.WriteLine("i : " + i);
                for(int j = 0; j < drives.Length; j++)
                {
                    Console.WriteLine("keyboards[i] " + keyboards[i]);
                    Console.WriteLine("drives[j] " + drives[j]);
                    cost = keyboards[i] + drives[j];
                    Console.WriteLine("cost : " + cost);
                    if((cost > maxValue) && (cost <= b))
                    {
                        maxValue = cost;
                    }
                    //if(cost < b)
                    //{
                    //    return maxValue;
                    //}
                    
                }
            }
            return maxValue;


        }
    }
}
