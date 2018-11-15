using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMealCost
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost;
            int tip_percent;
            int tax_percent;
            var totalCost = Solve(47.00, 20, 8);
            
        }

        static double Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip;
            double tax;
            double total_cost;
            tip = meal_cost * tip_percent / 100;
            Console.WriteLine("Tip: " + tip);
            tax = meal_cost * tax_percent / 100;
            Console.WriteLine("Tax: " + tax);

            total_cost = Math.Round(meal_cost + tip + tax);
            Console.WriteLine("total cost: " + total_cost);
            return total_cost;

        }

    }
}
