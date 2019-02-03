using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefresh
{
    public class Person
    {
        public string name;
        public int age;

        public Person()
        {

        }

        public Person(string n, int a)
        {
            this.name = n;
            this.age = a;
        }

        // operator over loading
        //Operator overloading is a function where different operators are applied and 
        // depends on the arguments. Operator,-,* can be used to pass through the function, and it has their own precedence to execute
        public static Person operator+ (Person p1, Person p2)
        {
            Person p = new Person();
            p.name = p1.name + p2.name;
            p.age = p1.age + p2.age;

            return p;

        }

        ~Person()
        {
            Console.WriteLine("Destructing in action " + name);
        }
    }
}
