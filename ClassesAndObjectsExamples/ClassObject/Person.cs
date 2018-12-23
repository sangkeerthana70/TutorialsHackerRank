using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    public class Person
    {
        string Name;
        int Age;
        string Profession;

        //public Person()
        //{
        //}

        public Person(string N, int A, string P)
        {
            this.Name = N;
            this.Age = A;
            this.Profession = P;
        }

        

        public void showDetails()
        {
            Console.Write("My name is: " + Name);
            Console.Write(" And I am: " + Age + " years old");
            Console.Write(" I am a " + Profession);
            Console.WriteLine();
        }

    }
}
