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
        }

        // Complete the minimumNumber function below.
        static int minimumNumber(int n,string password)
        {
            
            // Return the minimum number of characters to make the password strong
            for (int i = 0; i < password.Length; i++)
            {
                string special_characters = "!@#$%^&*()-+";
                if (password.Length == n)
                {

                    if (char.IsUpper(password[i]))
                    {
                        Console.WriteLine("has one upperCharacter");
                    }
                    if (char.IsLower(password[i]))
                    {
                        Console.WriteLine(("has one lower");
                    }
                    
                    for( int c = 0; c < special_characters.Length; c++)
                    {
                        if (password[i] == special_characters[c])
                        {
                            Console.WriteLine("has a special character");
                        }
                    }
                }
            }


        }
    }
}
