using System;
using System.Collections.Generic;
using Tree.Classes;
using Hashtable.Classes;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public List<int> TreeIntersection(BinaryTree treeOne, BinaryTree treeTwo)
    {
        HashTable visitedValues = new HashTable(20);
        List<int> commonValues = new List<int>();

        void TraversalOne(Node root)
        {
            if (root == null)
            {
                return;
            }

            visitedValues.Add(root.Value.ToString(), null);


        }
    }
}
