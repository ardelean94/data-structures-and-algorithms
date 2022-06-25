using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Arrays
{
    public class ArrayDemo
    {
        private int[] array = null;
        private int count = 0;
        public ArrayDemo(int Size)
        {
            array = new int[Size];
        }

        public void Insert(int element)
        {
            int[] tempArray = null;
            if (array.Length == count)
            {
                tempArray = new int[count * 2];
                array.CopyTo(tempArray, 0);
                array = tempArray;
            }
            array[count++] = element;
        }

        public void RemoveAt(int index) 
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException();

            for(int i = index; i < count-1; i++)
            {
                array[i] = array[i + 1];
            }
            count--;
        }

        public void Print()
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public int IndexOf(int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                    return i;
            }
            return -1;
        }

        /*
         * return the largest number. What is the runtime complexity of this method? 
         */
        public int Max()
        {
            int max = array[0];
            for (int i = 0; i < count; i++) // O(n)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        /*
         * return the common items in this array and another array. 
         */
        public static int[] Intersect(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr1.Length == 0 || arr2 == null || arr2.Length == 0)
                throw new ArgumentException();

            int size = arr1.Length >= arr2.Length ? arr1.Length : arr2.Length;
            int[] matches = new int[size];
            int index = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr2[j] == arr1[i])
                    {
                        matches[index] = arr1[i];
                        index++;
                        break;
                    }
                }
            }

            return matches;
        }

        /*
         * reverse the array. For example, if the array includes [1, 2, 3, 4], 
         * after reversing and printing it, we should see [4, 3, 2, 1]
         */
        public int[] Reverse()
        {
            int[] arr = new int[count];
            for(int i = count-1, j = 0; i >= 0; i--)    // O(n)
            {
                arr[j] = array[i];
                j++;
            }
            return arr;
        }

        /*
         * insert an item at a given index: public void insertAt(int item, int index)
         */
        public void InsertAt(int item, int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException();

            //1. Shift the array to the right from the index position
            //2. add the new item at index

            array[index] = item;
            count++;
        }
    }
}
