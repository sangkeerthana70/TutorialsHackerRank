using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectEx2
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

            Person Anu = new Person();
            Anu.Name = name;
            Anu.Age = age;
            Anu.Profession = profession;
            //call the method inside Person class
            Anu.ShowDetails();
            //take input for another instance of another class
            Console.Write("Name : ");
            name = Console.ReadLine();
            Console.Write("Age : ");
            age = Int32.Parse(Console.ReadLine());
            Console.Write("Profession : ");
            profession = Console.ReadLine();

            Person Keethu = new Person();
            Keethu.Name = name;
            Keethu.Age = age;
            Keethu.Profession = profession;
            Keethu.ShowDetails();


        }
    }
}
