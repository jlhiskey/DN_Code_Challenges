using System;
using System.Collections.Generic;
using StacksAndQueues.Classes;
using Tree.Classes;


namespace BreadthFirstTraversal
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(1);
            testTree.Root.Left = new Node(2);
            testTree.Root.Right = new Node(3);
            testTree.Root.Left.Left = new Node(4);
            testTree.Root.Left.Right = new Node(5);
            testTree.Root.Right.Left = new Node(6);
            testTree.Root.Right.Right = new Node(7);
            BreadthFirstTraversal(testTree);
            Console.ReadLine();
        }

        public static List<int> BreadthFirstTraversal(BinaryTree tree)
        {
            List<int> capturedValues = new List<int>();
            Queue queue = new Queue();
            if (tree.Root == null)
            {
                Console.WriteLine("Input Tree is Empty");
                return capturedValues;
            }
            queue.Enqueue(tree.Root);
            while (queue.Size != 0)
            {
                Node targetNode = queue.Peek().Value;
                capturedValues.Add(targetNode.Value);
                Console.WriteLine(targetNode.Value);
                if (targetNode.Left != null)
                {
                    queue.Enqueue(targetNode.Left);
                }
                if (targetNode.Right != null)
                {
                    queue.Enqueue(targetNode.Right);
                }
                queue.Dequeue();
            }

            return capturedValues;
        }

    }
}
