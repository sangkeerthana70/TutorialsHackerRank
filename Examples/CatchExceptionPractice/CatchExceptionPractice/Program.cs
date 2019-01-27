using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchExceptionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number");
            try
            {
                
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You have entered " + num);
            }
            catch(System.FormatException e)
            {
                Console.WriteLine("Invalid number supplied");
                Console.WriteLine(e); 
            }
            finally
            {
                Console.WriteLine("In the finally block");
            }


        }
    }
}
