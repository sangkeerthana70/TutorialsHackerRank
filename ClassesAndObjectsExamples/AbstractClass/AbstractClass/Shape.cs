using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // abstract class will enforce the derived classes to implement the abstract methods inside
    abstract class Shape
    {
        public string color;
        //public Shape()
        //{

        //}
        public virtual void About()
        {
            Console.WriteLine("I am a shape");
        }
        //abstract method will not have a body to its method
        public abstract string ThreeDShape();
        
    }
}
