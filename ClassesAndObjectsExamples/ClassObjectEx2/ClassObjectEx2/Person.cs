using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectEx2
{
    public class Person
    {
        public string Name { get; set; } 
        public int Age { get; set; }
        public string Profession { get; set; }

        public Person()
        {

        }

        public void ShowDetails()
        {
            Console.Write("My name is: " + this.Name );
            Console.Write(" And I am: " +  this.Age + " years old");
            Console.Write(" I am a " + this.Profession);
            Console.WriteLine();
        }
    }
}
