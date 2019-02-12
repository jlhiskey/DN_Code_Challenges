using System;
using Tree.Classes;

namespace IsBinaryTreeBalanced
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

            Console.WriteLine($"Tree Balanced = {IsBinaryTreeBalanced(testTreeTwo)}.");
            Console.WriteLine();

            Console.WriteLine("Whiteboard Test Three");

            BinaryTree testTreeThree = new BinaryTree();

            Console.WriteLine($"Tree Balanced = {IsBinaryTreeBalanced(testTreeThree)}.");
            Console.WriteLine();

            Console.ReadLine();
        }

        /// <summary>
        /// Takes in a tree as an input and returns a bool indicating if it is balanced.
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public static bool IsBinaryTreeBalanced(BinaryTree tree)
        {
            /// Helper method that will calculate the height of an input node.
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

            //Helper method that will return a bool indicating if a node is balanced.
            bool HelperIsBinaryTreeBalanced(Node helperRootTwo)
            {
                int leftHeight;
                int rightHeight;

                //Stops the process if the root is null
                if (helperRootTwo == null)
                {
                    return true;
                }
                
                // Calculates the height of the left and right children of input node.
                leftHeight = HelperCalculateBinaryTreeHeight(helperRootTwo.Left);
                rightHeight = HelperCalculateBinaryTreeHeight(helperRootTwo.Right);
                
                // Compares if left height and right height are within 1 of eachother and recursively calls to determine if all children and their children meet the same condition returns true if conditions are met.
                if (
                    Math.Abs(leftHeight - rightHeight) <= 
                    1 && 
                    HelperIsBinaryTreeBalanced(helperRootTwo.Left) && 
                    HelperIsBinaryTreeBalanced(helperRootTwo.Right)
                    )
                {
                    return true;
                }
                return false;
            }
            // Checks to see if tree is empty.
            if (tree.Root == null)
            {
                return true;
            }
            // Snags the root out of the tree
            Node root = tree.Root;

            bool isBalanced;

            // Runs the helper functions
            isBalanced = HelperIsBinaryTreeBalanced(root);
            return isBalanced;
        }

    }
}
