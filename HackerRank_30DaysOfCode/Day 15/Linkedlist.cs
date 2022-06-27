using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_15
{
    public class Linkedlist
    {
        public static Node Insert(Node head, int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return head;
            }

            if (head.next == null)
                head.next = new Node(data);
            else
                Insert(head.next, data);

            return head;
        }

        public static void Display(Node head)
        {
            Node start = head;
            while(start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }
}
