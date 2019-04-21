using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindConsecutiveOnesInABinaryString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string binaryVal = "111011110";
            string binaryVal = "11101111";
            int result = CheckConsecutiveOnes(binaryVal);
        }

        private static int CheckConsecutiveOnes(string binary)
        {

            /*
             * Pseudocode
             *First set up two variables
             *count : holds current value of consecutive 1s
             *maxCount: maximum consecutive values encountered in the string 
             
             *Loop through the string:
	           =>if current element is 1,
		            if this is the first element or if the previous element is 1, increment count
	           =>if current element is 0,
		            the consecutive occurence of 1 is broken
		            check if count is > maxCount. if so, set maxCount = count
		            set count to 0
             */

            int count = 0;
            int maxCount = 0;

            for (var i = 0; i < binary.Length; i++)
            {
                //Console.WriteLine("i: " + i);
                //Console.WriteLine("binary[i]: " + binary[i]);
                //Console.WriteLine(binary[i].GetType());
                //Console.WriteLine(binary[i] == '1');
                if (binary[i] == '1')
                {
                    // if first element is 1 or previous element is 1 or previous element is 0
                    if (i == 0 || binary[i - 1] == '1' || binary[i - 1] == '0')
                    {
                        count += 1;
                    }
                }

                if (binary[i] == '0')
                {
                    if (count > maxCount)
                    {

                        maxCount = count;
                        // reset count to 0
                        count = 0;
                    }

                }
                //Console.WriteLine("count: " + count);
                //Console.WriteLine("maxCount: " + maxCount);
            }
            if()
            Console.WriteLine("count: " + maxCount);
            return maxCount;

        }
    }
}
