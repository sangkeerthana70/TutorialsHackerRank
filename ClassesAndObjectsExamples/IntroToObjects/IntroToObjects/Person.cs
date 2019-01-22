using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToObjects
{
    class Person
    {
       public string name { get; set; }
       public string gender { get; set; }
       public int age { get; set; }
       public Car car { get; set; }

        //constructor
        public Person(string n, string g, int a)
        {
            this.name = n;
            this.gender = g;
            this.age = a;
            this.car = new Car();
            
        }

        public void printDetail()
        {
            Console.WriteLine(name + " is a " + gender + " and is " + age + " years old");

            if (!String.IsNullOrEmpty(car.make))
            {
                Console.WriteLine(name + " has a " + car.make + " " + car.model + " that is the model " + car.year + " and is " + car.color + " In color");
            }
            else
            {
                Console.WriteLine(name + " does not have a car");
            }
            
        }
    }
}
