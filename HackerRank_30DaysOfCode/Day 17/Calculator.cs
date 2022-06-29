using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_17
{
    class Calculator
    {
        public int Power(int n, int p)
        {
            if (n < 0 || p < 0)
                throw new Exception("n and p should be non-negative");

            return (int)Math.Pow(Convert.ToDouble(n), Convert.ToDouble(p));
        }
    }
}
