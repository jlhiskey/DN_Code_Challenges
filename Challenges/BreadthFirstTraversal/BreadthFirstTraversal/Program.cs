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
            Console.WriteLine("Balanced Tree");
            BinaryTree balancedTree = new BinaryTree();
            balancedTree.Root = new Node(1);
            balancedTree.Root.Left = new Node(2);
            balancedTree.Root.Right = new Node(3);
            balancedTree.Root.Left.Left = new Node(4);
            balancedTree.Root.Left.Right = new Node(5);
            balancedTree.Root.Right.Left = new Node(6);
            balancedTree.Root.Right.Right = new Node(7);

            BreadthFirstTraversal(balancedTree);
            Console.WriteLine();

            Console.WriteLine("Empty Tree");
            BinaryTree emptyTree = new BinaryTree();

            BreadthFirstTraversal(emptyTree);
            Console.WriteLine();

            Console.WriteLine("UnBalanced Tree");
            BinaryTree unbalancedTree = new BinaryTree();
            unbalancedTree.Root = new Node(1);
            unbalancedTree.Root.Left = new Node(2);
            unbalancedTree.Root.Right = new Node(3);
            unbalancedTree.Root.Left.Right = new Node(4);
            unbalancedTree.Root.Right.Left = new Node(5);
            unbalancedTree.Root.Right.Left.Left = new Node(6);

            BreadthFirstTraversal(unbalancedTree);

            Console.ReadLine();
        }

        /// <summary>
        /// Takes in a BinaryTree and returns a List<int> of visited nodes.
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public static List<int> BreadthFirstTraversal(BinaryTree tree)
        {
            List<int> capturedValues = new List<int>();
            Queue queue = new Queue();
            // Checks for empty tree
            if (tree.Root == null)
            {
                Console.WriteLine("Input Tree is Empty");
                return capturedValues;
            }
            //Adds root to queue
            queue.Enqueue(tree.Root);
            //Runs while queue is not empty
            while (queue.Size != 0)
            {
                //Populates visited node
                Node targetNode = queue.Peek().Value;

                //Captures visited node
                capturedValues.Add(targetNode.Value);
                Console.WriteLine(targetNode.Value);

                //Traverses tree
                if (targetNode.Left != null)
                {
                    queue.Enqueue(targetNode.Left);
                }
                if (targetNode.Right != null)
                {
                    queue.Enqueue(targetNode.Right);
                }
                //Removed captured value from queue
                queue.Dequeue();
            }

            return capturedValues;
        }

    }
}
