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

            BinaryTree testTreeOne = new BinaryTree();
            testTreeOne.Root = new Node(1);
            testTreeOne.Root.Left = new Node(2);
            testTreeOne.Root.Right = new Node(3);

            BinaryTree testTreeTwo = new BinaryTree();
            testTreeTwo.Root = new Node(4);
            testTreeTwo.Root.Left = new Node(1);
            testTreeTwo.Root.Right = new Node(2);

            List<int> values = Program.TreeIntersection(testTreeOne, testTreeTwo);

            Console.WriteLine("Common Values");
            foreach (int value in values)
            {
                Console.WriteLine($"Value = {value}");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Takes in two trees and returns of list of common values between both trees.
        /// </summary>
        /// <param name="treeOne"></param>
        /// <param name="treeTwo"></param>
        /// <returns>List<int> commonValues</int></returns>
        public static List<int> TreeIntersection(BinaryTree treeOne, BinaryTree treeTwo)
        {

            List<int> commonValues = new List<int>();
            HashTable visitedValues = new HashTable(20);

            // Traverses first tree and adds values to hashmap.
            void TraversalOne(Node root)
            {  
                if (root == null)
                {
                    return;
                }

                visitedValues.Add(root.Value.ToString(), null);
                TraversalOne(root.Left);
                TraversalOne(root.Right);
            }

            // Traverses second tree and adds values to list if value is contained within hashmap.
            void TraversalTwo(Node root)
            {
                if (root == null)
                {
                    return;
                }
                if (visitedValues.Contains(root.Value.ToString()))
                {
                    commonValues.Add(root.Value);
                }
                TraversalTwo(root.Left);
                TraversalTwo(root.Right);
            }

            // Fires both recursive methods.
            TraversalOne(treeOne.Root);
            TraversalTwo(treeTwo.Root);

            // Returns list of common values.
            return commonValues;
        }
    }

    
}
