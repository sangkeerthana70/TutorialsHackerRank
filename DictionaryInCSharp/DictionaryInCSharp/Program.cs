using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new dictionary of strings, with string keys, 
            // and access it through the IDictionary generic interface.
            IDictionary<string, string> d = new Dictionary<string, string>();


            // Add some elements to the dictionary. There are no 
            // duplicate keys, but some of the values are duplicates.
            d.Add("txt", "notepad.exe");
            d.Add("bmp", "paint.exe");
            d.Add("dib", "paint.exe");
            d.Add("rtf", "wordpad.exe");

            // The Add method throws an exception if the new key is 
            // already in the dictionary.
            try
            {
                d.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }
        }
    }

}
