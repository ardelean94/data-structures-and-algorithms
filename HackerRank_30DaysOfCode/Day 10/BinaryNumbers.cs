using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_10
{
    public class BinaryNumbers
    {
        public static int GetMaximumConsecutivesOne(int baseTenNumber)
        {
            if (baseTenNumber < 1)
                return 0;

            int sum = 0;
            int max = 0;
            var binaryNumber = ToBinaryBase(baseTenNumber);
            while (binaryNumber.Count != 0)
            {
                int bit = binaryNumber.Pop();
                if (bit == 1)
                {
                    sum++;
                }
                else
                {
                    if (sum > max)
                        max = sum;
                    sum = 0;
                }

                //  check last element
                if (binaryNumber.Count == 0 && sum > max)
                    max = sum;
            }

            return max;
        }

        public static Stack<int> ToBinaryBase(int n)
        {
            var binaryOutput = new Stack<int>();
            int number = n;
            while (number != 0)
            {
                int remainder = number % 2;
                binaryOutput.Push(remainder);
                number /= 2;
            }

            return binaryOutput;
        }
    }
}
