using System;
using FizzBuzzTree.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node("15");
            testTree.Root.Left = new Node("3");
            testTree.Root.Right = new Node("5");
            testTree.Root.Left.Left = new Node("4");
            testTree.Root.Left.Right = new Node("7");
            FizzBuzzTree(testTree);
            Console.ReadLine();
        }

        /// <summary>
        /// Takes in a binary tree with string numerical values converts them to integers check to see if integer is divisible by three and five, three, or five and changes value at node to FizzBuzz, Fizz, Buzz or keeps it the same if conditions arent met.
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public static BinaryTree FizzBuzzTree(BinaryTree tree)
        {
            Node root = tree.Root;
            /// Helper method that is conducting recursion.
            void HelperFizzBuzz(Node helperRoot)
            {
                if (helperRoot == null)
                {
                    return;
                }
                helperRoot.Value = CompareValue(ParseStringToInt(helperRoot));
                HelperFizzBuzz(helperRoot.Left);
                HelperFizzBuzz(helperRoot.Right);
            }

            /// Helper method that parses node value into an integer.
            int ParseStringToInt(Node targetNode)
            {
                return int.Parse(targetNode.Value);
            }

            /// Helper method that received parsed value and compares integer to FizzBuzz logic and returns appropriate string.
            string CompareValue(int targetNodeValue)
            {
                if (targetNodeValue % 3 == 0 && targetNodeValue % 5 == 0)
                {
                    return "FizzBuzz";
                }
                else if (targetNodeValue % 3 == 0)
                {
                    return "Fizz";
                }
                else if (targetNodeValue % 5 == 0)
                {
                    return "Buzz";
                }
                else
                {
                    return targetNodeValue.ToString();
                }
            }
            Console.WriteLine("Original Tree");
            tree.InOrder();
            HelperFizzBuzz(root);
            Console.WriteLine("FizzBuzz Tree");
            tree.InOrder();
            return tree;
        }
        
        
    }
}
