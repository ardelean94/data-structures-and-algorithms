using System.Collections.Generic;
using System;
using DataStructuresAndAlgorithms.Arrays;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_9;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_10;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_11;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_12;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_14;
using System.Linq;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.ComputeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
