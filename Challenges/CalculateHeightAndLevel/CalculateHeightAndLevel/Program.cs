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
            Console.WriteLine($"Tree Level = {CalculateBinaryTreeLevel(testTreeOne)}.");
            Console.WriteLine();

            Console.WriteLine("Whiteboard Test Two");

            BinaryTree testTreeTwo = new BinaryTree();
            testTreeTwo.Root = new Node(0);
            testTreeTwo.Root.Left = new Node(0);
            testTreeTwo.Root.Right = new Node(0);
            testTreeTwo.Root.Left.Left = new Node(0);
            testTreeTwo.Root.Right.Right = new Node(0);
            testTreeTwo.Root.Left.Left.Right = new Node(0);

            Console.WriteLine($"Tree Height = {CalculateBinaryTreeHeight(testTreeTwo)}.");
            Console.WriteLine($"Tree Level = {CalculateBinaryTreeLevel(testTreeTwo)}.");
            Console.WriteLine();

            Console.WriteLine("Whiteboard Test Three");

            BinaryTree testTreeThree = new BinaryTree();

            Console.WriteLine($"Tree Height = {CalculateBinaryTreeHeight(testTreeThree)}.");
            Console.WriteLine($"Tree Level = {CalculateBinaryTreeLevel(testTreeThree)}.");
            Console.WriteLine();

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

                //Collects Left and Right Height Values
                int leftChildHeight = HelperCalculateBinaryTreeHeight(helperRoot.Left);
                int rightChildHeight = HelperCalculateBinaryTreeHeight(helperRoot.Right);

                //Collects highest height found.
                int highestValue = Math.Max(leftChildHeight, rightChildHeight);

                //Returns actual highest value
                return highestValue + 1;
            }
            //Calls helper
            height = HelperCalculateBinaryTreeHeight(root);

            //Returns height
            return height;
        }

        /// <summary>
        /// Inputs a binary tree and returns an integer indicating height of input tree.
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public static int CalculateBinaryTreeLevel(BinaryTree tree)
        {
            //Since tree.Root would have a height of 0 and a level of 1 you just have to add one to the calculated height of a tree.
            int level = CalculateBinaryTreeHeight(tree) + 1;

            //Handles a empty tree.
            if (tree.Root == null)
            {
                return 0;
            }
            return level;
        }
    }
}
