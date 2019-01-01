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


            // Add elements to the dictionary. There are no 
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

            // Access elements in Dictionary using ForLoop
            for (int i = 0; i < d.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", d.Keys.ElementAt(i), d[d.Keys.ElementAt(i)]);

            }

            // Access Individual Element in the dictionary
            Console.WriteLine("For key = \"rtf\", value = {0}.",
            d["rtf"]);

            // TryGetValue() method
            string result;
            if (d.TryGetValue("cs", out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Could not find the specified key.");
            }

            // If a key does not exist, setting the indexer for that key
            // adds a new key/value pair.
            d["doc"] = "winword.exe";
            Console.WriteLine("For key = \"doc\", value = {0}.", d["doc"]);

            // Before adding a KeyValuePair into a dictionary, check that the key does not exist 
            //using the ContainsKey() method.

            Console.WriteLine(d.ContainsKey("bmp")); // returns true
            Console.WriteLine(d.ContainsKey("sql")); // returns false
            Console.WriteLine(d.Contains(new KeyValuePair<string, string>("doc", "winword.exe"))); // returns true

            // Remove elements from Dictionary
            d.Remove("dib");

            // removes nothing because value  "wordpad.exe" is not matching
            d.Remove(new KeyValuePair<string, string>("rtf", "wordpad.exe3"));
        }
    }

}
