using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable pangrams = new Hashtable();
            pangrams.Add(1, "I");
            pangrams.Add(2, "am");
            pangrams.Add(3, "learning");
            pangrams.Add(4, "about");
            pangrams.Add(5, "hash tables");

            // the keys property of Hashtable gets an ICollection containing the keys in the Hashtable.
            ICollection key = pangrams.Keys;
            foreach (int val in key)
            {
                // values Gets an ICollection containing the values in the Hashtable.
                Console.WriteLine(val + " " + pangrams[val]);
            }


        }
    }

    
}
