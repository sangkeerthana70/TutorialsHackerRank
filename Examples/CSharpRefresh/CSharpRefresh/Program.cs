﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefresh
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = " SuperBowl";

            Console.WriteLine(word);
            var result = CalcNumberOfCharactersInString(word);
            Console.WriteLine(word);

            //===========================================
            Console.WriteLine("Passing by reference");
            Person person = new Person(" Tom Brady", 41);
            Console.WriteLine(person.name);
            var result1 = CalcNumberOfCharactersInString(person);
            Console.WriteLine(person.name);
            //=============================================
            Console.WriteLine("Operator overloading");
            Person person2 = new Person("  Patrick Maholmes", 22);
            Person person3 = person + person2;

            Console.WriteLine(person3.name);
            Console.WriteLine(person3.age);
            // destructor will execute this code before doing actual garbage disposal
            // person2 and person will reference the same memory and person2 's memory 
            // will be unreferenced and forced to be cleared by the destructor
            person2 = person;
           
        }

        public static int CalcNumberOfCharactersInString(string word)
        {
            //  example of primitive types passed by value
            // the argument value is copied into another memory space and changes are only visible here and not outside the function
            word = (word.Trim(' '));
            int res = word.Length;
            Console.WriteLine(word);
            Console.WriteLine(res);
            return res;

        }

        public static int CalcNumberOfCharactersInString(Person person)
        {
            // example of an object passed by reference where an object's memory is referenced here and the changes made to the variable is also visible outside
            person.name = person.name.Trim();
            int res = person.name.Length;
            Console.WriteLine(person.name);
            Console.WriteLine(res);
            return res;


        }


    }
}
