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
            int input = 5;
            int[] keyBoards = new int[] { 4 };
            int[] usbDrives = new int[] { 5 };

           
            int result = getMoneySpent(keyBoards, usbDrives, input);
            Console.WriteLine("result: " + result);
            
        }

        
        // Complete the getMoneySpent function below.
        
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            //Write your code here.
            int maxKeyBoard = 0;
            int maxUsbDrive = 0;
            
            for(var i = 0; i < keyboards.Length; i++)
            {
                int maxValue = int.MinValue;
                
                if(keyboards[i] > maxValue)
                {
                    maxValue = keyboards[i];
                    
                    maxKeyBoard = maxValue;
                }
               
            }
            Console.WriteLine("maxValue of keyboard: " + maxKeyBoard);
            

            for(var j = 0; j < drives.Length; j++)
            {
                int maxValue = int.MinValue;
                if (drives[j] > maxValue)
                {
                    maxValue = drives[j];
                    
                    maxUsbDrive = maxValue;
                }
            }
            Console.WriteLine("maxValue of drive : " + maxUsbDrive);

            if(maxKeyBoard + maxUsbDrive <= b)
            {
                return maxKeyBoard + maxUsbDrive;
            }
            else
            {
                return -1;
            }
            

        }
    }
}
