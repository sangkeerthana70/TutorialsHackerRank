using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printArrayUsingGenerics
{
    class TestGenericList
    {
        private class ExampleClass { }
        static void Main(string[] args)
        {
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);
            list1.Add(100);
            

            // Declare a list of type string.
            GenericList<string> list2 = new GenericList<string>();
            list2.Add("Hello World");
            list2.Add("Generics in C#");

           

            // Declare a list of type ExampleClass.
            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            list3.Add(new ExampleClass());
        }

        // Declare the generic class.
        public class GenericList<T>
        {
            public void Add(T input) { }
            
            public void PrintList(T input)
            {
                for(var i = 0; i < 3; i++)
                {
                    Console.WriteLine(input);
                }
            }

        }
    }
}
