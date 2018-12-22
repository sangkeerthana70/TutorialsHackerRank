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
            bool upperCharFound = false;
            bool lowerCharFound = false;
            bool specialCharFound = false;
            bool numCharFound = false;
            int specialElementsFound = 0;
            //int passwordLength = password.Length;
            int minNumCharsToAdd = 0;
            int missingElem = 0;


            string special_characters = "!@#$%^&*()-+";
            string numbers = "0123456789";

            for (int i = 0; i < password.Length; i++)
            {
                    
                    if (char.IsUpper(password[i]))
                    {
                        upperCharFound = true;
                       // specialElementsFound += 1;
                        Console.WriteLine("has one upperCharacter");
                    }
                    if (char.IsLower(password[i]))
                    {
                        lowerCharFound = true;
                        //specialElementsFound += 1;
                        Console.WriteLine("has one lower");
                    }
                    
                    for( int c = 0; c < special_characters.Length; c++)
                    {
                        if ((password[i] == special_characters[c]))
                        {
                            specialCharFound = true;
                            //specialElementsFound += 1;
                            Console.WriteLine("has a special character");
                        }
                    }

                    for ( int num = 0; num < numbers.Length; num++)
                    {
                        if((password[i] == numbers[num]))
                        {
                            numCharFound = true;
                            //specialElementsFound += 1;
                            Console.WriteLine("Has one number"); 
                        }
                    }

                    
            }
            //Console.WriteLine("specialElementsFound: " + specialElementsFound);

            if (specialElementsFound < 4)
            {
                missingElem = 4 - specialElementsFound;
                Console.WriteLine("missingElem " + missingElem);
            }

            missingElem = 0;

            if (!upperCharFound)
            {
                missingElem++;
            }

            if (!lowerCharFound)
            {
                missingElem++;
            }

            if (!specialCharFound)
            {
                missingElem++;
            }

            if (!numCharFound)
            {
                missingElem++;
            }

            if ( (n + missingElem) >= 6)
            {
                minNumCharsToAdd = missingElem;
            }
            else
            {
                minNumCharsToAdd =  6 - n;
            }
            Console.WriteLine(minNumCharsToAdd);
            return minNumCharsToAdd;

        }
    }
}
