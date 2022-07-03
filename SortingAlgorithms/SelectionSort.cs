using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    class SelectionSort
    {
        public static void Sort(int[] array)
        {
            bool needsSwap;
            for(int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                needsSwap = false;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                        needsSwap = true;
                    } 
                }
                if (needsSwap)
                    Swap(array, minIndex, i);
            }
        }

        private static void Swap(int[] array, int index1, int index2)
        {
            var temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
