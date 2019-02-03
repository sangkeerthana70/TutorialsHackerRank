using System;
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
            Console.WriteLine();
            Person person = new Person(" Anu", 70);
            Console.WriteLine(person.name);
            var result1 = CalcNumberOfCharactersInString(person);
            Console.WriteLine(person.name);

           
        }

        
    }
}
