using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    class BubbleSort
    {
        public static void Sort(int[] array)
        {
            bool isSorted;

            for(int i = 0; i < array.Length; i++)
            {
                isSorted = true;
                for(int j = 1; j < array.Length - i; j++)
                {
                    if (array[j] < array[j - 1])
                    {
                        Swap(array, j, j - 1);
                        isSorted = false;
                    }
                }
                if (isSorted)
                    return;
            }
        }

        private static void Swap(int[] array, int index1, int index2)
        {
            var aux = array[index1];
            array[index1] = array[index2];
            array[index2] = aux;
        }

        public static void SortDesc(int[] array)
        {
            bool isSorted;

            for(int i = 0; i < array.Length; i++)
            {
                isSorted = true;
                for(int j = 1; j < array.Length - i; j++)
                {
                    if(array[j] > array[j - 1])
                    {
                        Swap(array, j, j - 1);
                        isSorted = false;
                    }
                }
                if (isSorted)
                    return;
            }
        }
    }
}
