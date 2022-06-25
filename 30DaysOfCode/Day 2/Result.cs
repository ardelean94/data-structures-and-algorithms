using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms._30DaysOfCode.Day_2
{
    public class Result
    {
        public static void Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            var tip = tip_percent / 100.00 * meal_cost;
            var tax = tax_percent / 100.00 * meal_cost;
            var total_cost = meal_cost + tip + tax;
            Console.WriteLine(Math.Round(total_cost));
        }
    }
}
