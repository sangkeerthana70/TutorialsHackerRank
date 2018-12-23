using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Age : ");
            int age = Int32.Parse(Console.ReadLine());
            Console.Write("Profession : ");
            string profession = Console.ReadLine();
            // Person is a class with three properties
            // Here we are instantiating a person object and pass values to its constructor
            Person Anu = new Person(name, age, profession);
            //person.showDetails();
            Console.Write("Name : ");
            name = Console.ReadLine();
            Console.Write("Age : ");
            age = Int32.Parse(Console.ReadLine());
            Console.Write("Profession : ");
            profession = Console.ReadLine();

            Person Senthil = new Person(name, age, profession);
            Anu.showDetails();
            Senthil.showDetails();


           



        }
    }
}
