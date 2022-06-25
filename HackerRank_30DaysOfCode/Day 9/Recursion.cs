using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_9
{
    public class Recursion
    {
        public static int factorial(int n)
        {
            if (n > 1)
                return n * factorial(n - 1);

            if (n == 1)
                return n;

            return n;
        }
    }
}
