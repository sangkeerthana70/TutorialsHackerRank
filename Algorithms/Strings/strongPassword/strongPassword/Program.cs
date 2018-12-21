using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strongPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            string password = "Ab1";
            int answer = minimumNumber(n, password);
            Console.WriteLine("Answer: " + answer);
        }

        // Complete the minimumNumber function below.
        static int minimumNumber(int n,string password)
        {

            // Return the minimum number of characters to make the password strong
            bool upperCharFound = false;
            bool lowerCharFound = false;
            bool specialCharFound = false;
            bool numCharFound = false;
            int result = 0;
            int passwordCount = password.Length;
            string special_characters = "!@#$%^&*()-+";
            string numbers = "0123456789";

            for (int i = 0; i < password.Length; i++)
            {
      
                    if (char.IsUpper(password[i]))
                    {
                        upperCharFound = true;
                        Console.WriteLine("has one upperCharacter");
                    }
                    if (char.IsLower(password[i]))
                    {
                        lowerCharFound = true;
                        Console.WriteLine("has one lower");
                    }
                    
                    for( int c = 0; c < special_characters.Length; c++)
                    {
                        if (password[i] == special_characters[c])
                        {
                            specialCharFound = true;
                            Console.WriteLine("has a special character");
                        }
                    }

                    for ( int num = 0; num < numbers.Length; num++)
                    {
                        if(password[i] == numbers[num])
                        {
                            numCharFound = true;
                            Console.WriteLine("Has one number");
                        }
                    }
                  
                    

            }
            
            return passwordCount;


        }
    }
}
