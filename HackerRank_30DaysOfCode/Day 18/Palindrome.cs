using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_18
{
    class Palindrome
    {
        public static bool IsPalindrome(string input)
        {
            var stack = new Stack<char>();
            var queue = new Queue<char>();
            bool isPalindrome = true;

            foreach(char c in input)
            {
                stack.Push(c);
                queue.Enqueue(c);
            }

            while(stack.Count != 0)
            {
                if(stack.Pop() != queue.Dequeue())
                {
                    isPalindrome = false;
                    break;
                }  
            }

            return isPalindrome;
        }
    }
}
