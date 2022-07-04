using System.Collections.Generic;
using System;
using DataStructuresAndAlgorithms.Arrays;
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

            HackerRank_30DaysOfCode.Day_22.Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = HackerRank_30DaysOfCode.Day_22.BinarySearchTree.Insert(root, data);
            }
            int height = HackerRank_30DaysOfCode.Day_22.BinarySearchTree.GetHeight(root);
            Console.WriteLine(height);
        }
    }
}
