using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    class InsertionSort
    {
        public static void Sort(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                int current = array[i];
                int j = i - 1;
                while(j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];    //  shift to the right
                    j--;
                }
                array[j + 1] = current;
            }
        }
    }
}
