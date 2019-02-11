using System;
using Tree.Classes;

namespace CalculateHeightAndLevel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whiteboard Test One");

            BinaryTree testTreeOne = new BinaryTree();
            testTreeOne.Root = new Node(0);
            testTreeOne.Root.Left = new Node(0);
            testTreeOne.Root.Right = new Node(0);

            Console.WriteLine($"Tree Height = {CalculateBinaryTreeHeight(testTreeOne)}.");

            Console.WriteLine("Whiteboard Test Two");

            BinaryTree testTreeTwo = new BinaryTree();
            testTreeTwo.Root = new Node(0);
            testTreeTwo.Root.Left = new Node(0);
            testTreeTwo.Root.Right = new Node(0);
            testTreeTwo.Root.Left.Left = new Node(0);
            testTreeTwo.Root.Right.Right = new Node(0);
            testTreeTwo.Root.Left.Left.Right = new Node(0);

            Console.WriteLine($"Tree Height = {CalculateBinaryTreeHeight(testTreeTwo)}.");

            Console.WriteLine("Whiteboard Test Three");

            BinaryTree testTreeThree = new BinaryTree();

            Console.WriteLine($"Tree Height = {CalculateBinaryTreeHeight(testTreeThree)}.");

            Console.ReadLine();
        }

        /// <summary>
        /// Inputs a binary tree and returns integer indicating height of input tree.
        /// </summary>
        /// <param name="tree"></param>
        /// <returns>int height</returns>
        public static int CalculateBinaryTreeHeight(BinaryTree tree)
        {
            int height;
            Node root = tree.Root;  

            //Checks to see if tree has nodes.
            if (root == null)
            {
                return 0;
            }

            int HelperCalculateBinaryTreeHeight(Node helperRoot)
            {
                //Stops recursion if node is null
                if (helperRoot == null)
                {
                    return -1;
                }
                //Stops recursion if leaf is found.
                if(helperRoot.Left == null && helperRoot.Right == null)
                {
                    return 0;
                }

                int leftChildHeight = HelperCalculateBinaryTreeHeight(helperRoot.Left);
                int rightChildHeight = HelperCalculateBinaryTreeHeight(helperRoot.Right);

                int highestValue = Math.Max(leftChildHeight, rightChildHeight);
                return highestValue + 1;
            }
            height = HelperCalculateBinaryTreeHeight(root);
            return height;
        }
    }
}
