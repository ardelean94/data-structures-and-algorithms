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
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_21;
using DataStructuresAndAlgorithms.SortingAlgorithms;
using System.Linq;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { 23, 58, 100, 4, -4, 2, 1000, 543, 0, 20, 20 };
            ////int[] array = new int[] { 8, 2, 4, 1, 3 };
            ////BubbleSort.Sort(array);
            ////BubbleSort.SortDesc(array);
            ////SelectionSort.Sort(array);
            ////InsertionSort.Sort(array);

            //foreach (var element in array)
            //    Console.WriteLine(element);

            int n = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            n = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            Printer.PrintArray<Int32>(intArray);
            Printer.PrintArray<String>(stringArray);
        }
    }
}
