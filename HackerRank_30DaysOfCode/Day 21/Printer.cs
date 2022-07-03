using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_21
{
    class Printer
    {
        public static void PrintArray<T>(T[] array)
        {
            for(int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}
