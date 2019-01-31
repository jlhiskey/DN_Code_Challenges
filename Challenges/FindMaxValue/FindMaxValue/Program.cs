using System;
using Tree.Classes;


namespace FindMaxValue
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(2);
            testTree.Root.Left = new Node(7);
            testTree.Root.Right = new Node(5);
            testTree.Root.Left.Left = new Node(2);
            testTree.Root.Left.Right = new Node(6);
            testTree.Root.Left.Right.Left = new Node(5);
            testTree.Root.Left.Right.Right = new Node(11);
            testTree.Root.Right.Right = new Node(9);
            testTree.Root.Right.Right.Left = new Node(4);

            FindMaxValue(testTree);
            Console.Read();
        }

        /// <summary>
        /// Takes in a tree as an input and returns nodes value that is highest within tree.
        /// </summary>
        /// <param name="tree"></param>
        /// <returns>int maxValue</returns>
        public static int FindMaxValue(BinaryTree tree)
        {
            Console.WriteLine("Node Values");
            Console.WriteLine(tree.InOrder());
            int maxValue = 0;
            Node root = tree.Root;

            /// Helper function that is actually doing the traversal.
            void Helper(Node helperRoot)
            {
                if (helperRoot == null)
                {
                    return;
                }
                maxValue = CompareValues(helperRoot.Value, maxValue);
                Helper(helperRoot.Left);
                Helper(helperRoot.Right);
            }
    
            /// Helper function that is comparing values and returning highest value.
            int CompareValues(int incomingValue, int highestValue)
            {
                if (incomingValue > highestValue)
                {
                    highestValue = incomingValue;
                }
                return highestValue;
            }

            Helper(root);

            Console.WriteLine($"Maximum Value found in tree = {maxValue}");
            return maxValue;
        }
    }
}