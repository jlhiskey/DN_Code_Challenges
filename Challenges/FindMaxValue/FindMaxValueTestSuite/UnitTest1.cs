using FindMaxValue;
using System;
using Tree.Classes;
using Xunit;

namespace FindMaxValueTestSuite
{
    public class FindMaxValueTestSuite
    {
        [Fact]
        public void TestingUsingChallengeExample()
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

            Assert.Equal(11, Program.FindMaxValue(testTree));
        }

        [Fact]
        public void TestingUsingMultipleMaxValues()
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(7);
            testTree.Root.Left = new Node(7);
            testTree.Root.Right = new Node(9);
            testTree.Root.Left.Left = new Node(9);
            testTree.Root.Left.Right = new Node(6);
            testTree.Root.Left.Right.Left = new Node(5);
            testTree.Root.Left.Right.Right = new Node(11);
            testTree.Root.Right.Right = new Node(9);
            testTree.Root.Right.Right.Left = new Node(11);

            Assert.Equal(11, Program.FindMaxValue(testTree));
        }

        [Fact]
        public void TestingUsingEmptyTree()
        {
            BinaryTree testTree = new BinaryTree();
            

            Assert.Equal(0, Program.FindMaxValue(testTree));
        }
    }
}
