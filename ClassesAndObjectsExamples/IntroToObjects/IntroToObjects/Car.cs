using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToObjects
{
    class Car
    {
        public string make { get; set; }
        public string color { get; set; }
        public string model { get; set; }
        public int year { get; set; }


        //constructor
        public Car(string m, string c, string mod, int y)
        {
            this.make = m;
            this.color = c;
            this.model = mod;
            this.year = y;

        }
        //empty constructor
        public Car()
        {
            

        }
    }
}
