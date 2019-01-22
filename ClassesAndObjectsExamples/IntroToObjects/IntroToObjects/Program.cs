using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var senthil = new Person("Sam", "Male", 45);

            //var car = new Car("Honda ", "Siler", "Odyssey", 2010);
            var car = new Car
            {
                make = "Honda",
                year = 2010,
                model = "Odyssey",
                color = "Silver"
            };

            senthil.car = car;
            senthil.printDetail();
            Console.WriteLine();

            var anu = new Person("Beenu", "Female", 40);
            //anu.car = new Car("Honda ", "Siler", "Accord", 2014);
            anu.car = new Car
            {
                make = "Honda",
                year = 2014,
                model = "Accord",
                color = "red"
            };
            anu.printDetail();
            Console.WriteLine();

            var keethu = new Person("Ana", "Female", 16);
            keethu.printDetail();
            Console.WriteLine();

            var geethu = new Person("Sammy", "Female", 10);
            geethu.printDetail();
            Console.WriteLine();

            //attributes can be changed after constructing
            senthil.age = 42;
            senthil.printDetail();
            Console.WriteLine();

            Person nameReturned = WhoIsOlder(keethu, geethu);
            Console.WriteLine(nameReturned.name + "  is Older of " + keethu.name + " and " + geethu.name);
            Console.WriteLine();

            string olderPerson = NameOfOldest(senthil, anu);
            Console.WriteLine(olderPerson + " is Older of " + senthil.name + " and " + anu.name);
            Console.WriteLine();


        }

        //this method returns an object that is of type Person
        public static Person WhoIsOlder(Person p1, Person p2)
        {
            if (p1.age > p2.age)
            {
                return p1;

            }

            else
            {
                return p2;

            }

        }

        //this method returns a string value 
        public static string NameOfOldest(Person p3, Person p4)
        {
            if (p3.age > p4.age)
            {
                return p3.name;
            }
            else
            {
                return p4.name;
            }
        }

    }
    
}
