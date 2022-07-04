using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.HackerRank_30DaysOfCode.Day_22
{
    class BinarySearchTree
    {
        public static Node Insert(Node root, int data)
        {
            if (root == null)
                return new Node(data);
            else
            {
                Node current;
                if(data <= root.data)
                {
                    current = Insert(root.left, data);
                    root.left = current;
                }
                else
                {
                    current = Insert(root.right, data);
                    root.right = current;
                }
                return root;
            }
        }

        public static int GetHeight(Node root)
        {
            if (root == null)
                return -1;

            if (root.left == null && root.right == null)
                return 0;

            return 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
            
        }
    }
}
