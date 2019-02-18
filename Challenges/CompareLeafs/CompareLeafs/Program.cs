using System;
using Tree.Classes;

namespace CompareLeaves
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Example One");

            BinaryTree testTreeOne = new BinaryTree();
            testTreeOne.Root = new Node(0);
            testTreeOne.Root.Left = new Node(0);
            testTreeOne.Root.Right = new Node(0);
            testTreeOne.Root.Left.Left = new Node(0);
            testTreeOne.Root.Left.Right = new Node(0);
            testTreeOne.Root.Right.Right = new Node(0);
            testTreeOne.Root.Left.Right.Left = new Node(0);
            testTreeOne.Root.Left.Right.Right = new Node(0);
            testTreeOne.Root.Right.Right.Left = new Node(0);
            testTreeOne.Root.Right.Right.Right = new Node(0);

            BinaryTree testTreeTwo = new BinaryTree();
            testTreeTwo.Root = new Node(0);
            testTreeTwo.Root.Left = new Node(0);
            testTreeTwo.Root.Right = new Node(0);
            testTreeTwo.Root.Left.Left = new Node(0);
            testTreeTwo.Root.Right.Right = new Node(0);
            testTreeTwo.Root.Left.Left.Left = new Node(0);
            testTreeTwo.Root.Left.Left.Right = new Node(0);
            testTreeTwo.Root.Right.Right.Left = new Node(0);
            testTreeTwo.Root.Right.Right.Right = new Node(0);
            testTreeTwo.Root.Right.Right.Right.Left = new Node(0);
            testTreeTwo.Root.Right.Right.Right.Right = new Node(0);
            
            CompareLeaves(testTreeOne, testTreeTwo);
            Console.WriteLine();

            Console.WriteLine("Class Example Two");

            BinaryTree testTreeThree = new BinaryTree();
            testTreeThree.Root = new Node(0);
            testTreeThree.Root.Left = new Node(0);
            testTreeThree.Root.Right = new Node(0);
            testTreeThree.Root.Left.Left = new Node(0);
            testTreeThree.Root.Left.Right = new Node(0);
            testTreeThree.Root.Right.Right = new Node(0);
            testTreeThree.Root.Left.Right.Left = new Node(0);
            testTreeThree.Root.Left.Right.Right = new Node(0);
            testTreeThree.Root.Right.Right.Left = new Node(0);

            BinaryTree testTreeFour = new BinaryTree();
            testTreeFour.Root = new Node(0);
            testTreeFour.Root.Left = new Node(0);
            testTreeFour.Root.Right = new Node(0);
            testTreeFour.Root.Left.Left = new Node(0);
            testTreeFour.Root.Right.Left = new Node(0);
            testTreeFour.Root.Right.Right = new Node(0);
            testTreeFour.Root.Left.Left.Right = new Node(0);
            testTreeFour.Root.Right.Right.Left = new Node(0);

            CompareLeaves(testTreeThree, testTreeFour);

            Console.ReadLine();
        }

        /// <summary>
        /// Takes two trees as an input and compares number of leaves that each tree has and returns true if they have equal number of leaves.
        /// </summary>
        /// <param name="treeOne"></param>
        /// <param name="treeTwo"></param>
        /// <returns>bool</returns>
        public static bool CompareLeaves(BinaryTree treeOne, BinaryTree treeTwo)
        {
            Console.WriteLine("Compare Leaves");

            Node rootOne = treeOne.Root;
            Node rootTwo = treeTwo.Root;

            //Checks input trees for nodes
            if (rootOne == null && rootTwo == null)
            {
                Console.WriteLine("Both trees are empty therefore the both have the same number of leaves.");
                return true;
            }

            if (rootOne == null || rootTwo == null)
            {
                Console.WriteLine("One of the trees is empty therefore they don't have equal leaves.");
                return false;
            }

            int leafCounterOne = 0;
            int leafCounterTwo = 0;

            //Helper function that runs the recursion on tree one.
            void HelperOne(Node helperRootOne)
            {
                if (helperRootOne == null)
                {
                    return;
                }
                //Adds to counterOne if a leaf is found.
                if (helperRootOne.Left == null && helperRootOne.Right == null)
                {
                    leafCounterOne = leafCounterOne + 1;
                }
                HelperOne(helperRootOne.Left);
                HelperOne(helperRootOne.Right);
            }

                void HelperTwo(Node helperRootTwo)
            {
                if (helperRootTwo == null)
                {
                    return;
                }
                //Adds to counterTwo if a leaf is found.
                if (helperRootTwo.Left == null && helperRootTwo.Right == null)
                {
                    leafCounterTwo = leafCounterTwo + 1;
                }
                HelperTwo(helperRootTwo.Left);
                HelperTwo(helperRootTwo.Right);
            }

            //Runs both trees using recursion.
            HelperOne(rootOne);
            HelperTwo(rootTwo);
            //Helper(rootTwo, leafCounterTwo);
            Console.WriteLine($"Tree One has {leafCounterOne} leaves. Tree Two has {leafCounterTwo} leaves.");
            //Compares leaves.
            if (leafCounterOne == leafCounterTwo)
            {
                Console.WriteLine("The leaves are equal");
                return true;
            }
            else
            {
                Console.WriteLine("The leaves are not equal");
                return false;
            }
        }
    }
}
