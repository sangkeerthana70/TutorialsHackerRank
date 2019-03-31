using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonAppetit
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            List<int> billList = new List<int> { 3, 10, 2, 9 };
            int amountCharged = 7;

            bonAppetit(billList, index, amountCharged);
        }

        // Complete the bonAppetit function below.
        static void bonAppetit(List<int> bill, int k, int b)
        {
            //Console.WriteLine("b is "  + b);
            int billTotal = 0;
            int annaOws = 0;
            
            //Console.WriteLine("bill[k] " + bill[k]);
            for (int i = 0; i < bill.Count; i++)
            {
                billTotal += bill[i];
                //Console.WriteLine("billTotal : " + billTotal);
            }
            annaOws = (billTotal - bill[k]) / 2;
            //Console.WriteLine("annaOws: " + annaOws);
            if(b == annaOws)
            {
               // Console.WriteLine("inside if");
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                //Console.WriteLine("in else");
                int amtBrianOwsAnna = b - annaOws;
                //Console.WriteLine("amtBrianOwsAnna: " + amtBrianOwsAnna);
            }

        }

    }
}
