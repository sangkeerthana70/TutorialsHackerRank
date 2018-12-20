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
            int n = 11;
            string password = "#HackerRank";
            int answer = minimumNumber(n, password);
            Console.WriteLine("Answer: " + answer);
        }

        // Complete the minimumNumber function below.
        static int minimumNumber(int n,string password)
        {

            // Return the minimum number of characters to make the password strong
            int uppChar = 0;
            int lowerChar = 0;
            int specialChar = 0;
            int numChar = 0;
            int passwordCount = password.Length;
            string special_characters = "!@#$%^&*()-+";
            string numbers = "0123456789";

            for (int i = 0; i < password.Length; i++)
            {
                
                if (password.Length == n)
                {

                    if (char.IsUpper(password[i]))
                    {
                        uppChar += 1;
                        Console.WriteLine("has one upperCharacter");
                    }
                    if (char.IsLower(password[i]))
                    {
                        lowerChar += 1;
                        Console.WriteLine("has one lower");
                    }
                    
                    for( int c = 0; c < special_characters.Length; c++)
                    {
                        if (password[i] == special_characters[c])
                        {
                            specialChar += 1;
                            Console.WriteLine("has a special character");
                        }
                    }

                    for ( int num = 0; num < numbers.Length; num++)
                    {
                        if(password[i] == numbers[num])
                        {
                            numChar += 1;
                        }
                    }
                  
                }

            }
            if ((uppChar == 1 && lowerChar == 1 && specialChar == 1 && numChar == 1) && passwordCount == 8)
            {
                Console.WriteLine("Has all requirements");
                return passwordCount;
                
            }
            else
            {
                Console.WriteLine("Not met all requirements");
                
            }
            return passwordCount;


        }
    }
}
