using System;
using Tree.Classes;

namespace IsBinaryTreeBalanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whiteboard Test One");

            BinaryTree testTreeOne = new BinaryTree();
            testTreeOne.Root = new Node(0);
            testTreeOne.Root.Left = new Node(0);
            testTreeOne.Root.Right = new Node(0);

            Console.WriteLine($"Tree Balanced = {IsBinaryTreeBalanced(testTreeOne)}.");
            Console.WriteLine();

            Console.WriteLine("Whiteboard Test Two");

            BinaryTree testTreeTwo = new BinaryTree();
            testTreeTwo.Root = new Node(0);
            testTreeTwo.Root.Left = new Node(0);
            testTreeTwo.Root.Right = new Node(0);
            testTreeTwo.Root.Left.Left = new Node(0);
            testTreeTwo.Root.Right.Right = new Node(0);
            testTreeTwo.Root.Left.Left.Right = new Node(0);
            testTreeTwo.Root.Left.Left.Right.Left = new Node(0);
            testTreeTwo.Root.Left.Left.Right.Right = new Node(0);

            Console.WriteLine($"Tree Balanced = {IsBinaryTreeBalanced(testTreeTwo)}.");
            Console.WriteLine();

            Console.WriteLine("Whiteboard Test Three");

            BinaryTree testTreeThree = new BinaryTree();

            Console.WriteLine($"Tree Balanced = {IsBinaryTreeBalanced(testTreeThree)}.");
            Console.WriteLine();

            Console.ReadLine();
        }

        public static bool IsBinaryTreeBalanced(BinaryTree tree)
        {
            int leftHeight = 0;
            int rightHeight = 0;
            if (tree.Root == null)
            {
                return true;
            }
            
            int HelperCalculateBinaryTreeHeight(Node helperRoot)
            {
                //Stops recursion if node is null
                if (helperRoot == null)
                {
                    return -1;
                }
                //Stops recursion if leaf is found.
                if (helperRoot.Left == null && helperRoot.Right == null)
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

            if (tree.Root.Left != null)
            {
                leftHeight = HelperCalculateBinaryTreeHeight(tree.Root.Left);
            }
            if (tree.Root.Right != null)
            {
                rightHeight = HelperCalculateBinaryTreeHeight(tree.Root.Right);
            }

            if (leftHeight - rightHeight > 1 || rightHeight - leftHeight > 1)
            {
                return false;
            }
            return true;
        }

    }
}
