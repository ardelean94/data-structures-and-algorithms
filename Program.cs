using System.Collections.Generic;
using System;
using DataStructuresAndAlgorithms.Arrays;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_9;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_10;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_11;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_12;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_14;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_15;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_16;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_17;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_18;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_19;
using DataStructuresAndAlgorithms.SortingAlgorithms;
using System.Linq;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 23, 58, 100, 4, -4, 2, 1000, 543, 0, 20, 20 };
            //int[] array = new int[] { 8, 2, 4, 1, 3 };
            //BubbleSort.Sort(array);
            //BubbleSort.SortDesc(array);
            SelectionSort.Sort(array);

            foreach (var element in array)
                Console.WriteLine(element);
        }
    }
}
