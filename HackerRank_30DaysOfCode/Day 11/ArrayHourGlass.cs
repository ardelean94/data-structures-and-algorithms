using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_11
{
    public class ArrayHourGlass
    {
        public static int GetMaxSumHourGlass(List<List<int>> arr)
        {
            int max = 0;
            int rowStartIteration = 0;
            int colStartIteration = 0;

            int[,] pattern = InitPattern();
            int[,] hourglass = GetHourGlass(arr, pattern);
            int hourglassSum = GetSumHourglass(hourglass);

            if (hourglassSum > max)
                max = hourglassSum;

            return max;

        }

        private static int[,] GetHourGlass(List<List<int>> array, int[,] pattern)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (!((i == 1 && j == 0) || (i == 1 && j == 2)))
                    {
                        pattern[i, j] = array[i][j];
                    }
                }
            }

            return pattern;
        }

        private static int GetSumHourglass(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }

            return sum;
        }

        private static int[,] InitPattern()
        {
            int[,] pattern = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    pattern[i, j] = 0;

            return pattern;
        }
    }
}
