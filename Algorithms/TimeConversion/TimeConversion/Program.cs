using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "04:59:59AM";

            string result = timeConversion(s);
            Console.WriteLine(result);
        }

        //Complete the timeConversion function below.

        static string timeConversion(string s)
        {
            //Returns a string array that contains the substrings 
            //in this instance that are delimited by elements of a 
            //specified string or Unicode character array.
            String[] strSplit = s.Split(':');
            var result = "";
            foreach (var strChar in strSplit)
            {
                Console.WriteLine(strChar);
            }

            //substring the third element in the array after spliting.
            var sSubStr = strSplit[2].Substring(2);
            Console.WriteLine(sSubStr);
            //If PM
            if(sSubStr == "PM")
            {
                //if hour is 12 
                if(Int32.Parse(strSplit[0]) == 12)
                {
                    result = strSplit[0] + ":" + strSplit[1] + ":" + strSplit[2].Remove(2, 2);
                }
                //if hour is not 12
                else
                {
                    var addTwelve = Int32.Parse(strSplit[0]) + 12;
                    Console.WriteLine("Add 12: " + addTwelve);
                    result = addTwelve + ":" + strSplit[1] + ":" + strSplit[2].Remove(2, 2);
                }
                
            }
            // if AM         
            else if(sSubStr == "AM")
            {
                if (Int32.Parse(strSplit[0]) < 6)
                {
                    result = strSplit[0] + ":" + strSplit[1] + ":" + strSplit[2].Remove(2, 2);
                }
                else
                {
                    var removeTwelve = 12 - Int32.Parse(strSplit[0]);

                    Console.WriteLine("remove 12: " + removeTwelve);
                    result = "0" + removeTwelve + ":" + strSplit[1] + ":" + strSplit[2].Remove(2, 2);
                }
            }                      
            return result;

        }

    }
}
