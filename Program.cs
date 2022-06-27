using System.Collections.Generic;
using System;
using DataStructuresAndAlgorithms.Arrays;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_9;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_10;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_11;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_12;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_14;
using DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_15;
using System.Linq;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = null;
            int T = int.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = int.Parse(Console.ReadLine());
                head = Linkedlist.Insert(head, data);
            }
            Linkedlist.Display(head);
        }
    }
}
