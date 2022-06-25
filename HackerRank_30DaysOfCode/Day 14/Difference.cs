using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_14
{
    public class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public void ComputeDifference()
        {
            if (elements.Length == 0)
                return;

            if (elements.Length == 1)
            {
                maximumDifference = elements[0];
                return;
            }

            int absoluteDifference = 0;
            for(int i = 0; i < elements.Length; i++)
            {
                absoluteDifference = GetMaximumAbsoluteDifferenceForElement(elements[i]);

                if (absoluteDifference > maximumDifference)
                    maximumDifference = absoluteDifference;
            }
        }

        private int GetMaximumAbsoluteDifferenceForElement(int element)
        {
            int maxAbsForElement = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                maxAbsForElement = GetAbsoluteDifference(element, elements[i]);

                if (maxAbsForElement > maximumDifference)
                    maximumDifference = maxAbsForElement;
            }

            return maxAbsForElement;
        }

        private int GetAbsoluteDifference(int element1, int element2)
        {
            int difference = element1 - element2;

            if (difference < 0)
                difference *= -1;

            return difference;
        }
    }
}
