using System;
using Tree.Classes;
using Xunit;
using CalculateHeightAndLevel;

namespace CalcHeightAndLevelTestSuite
{
    public class CalculateBinaryTreeHeightTestSuite
    {
        [Fact]
        public void TestingWhiteBoardExampleOne()
        {
            BinaryTree testTreeOne = new BinaryTree();
            testTreeOne.Root = new Node(0);
            testTreeOne.Root.Left = new Node(0);
            testTreeOne.Root.Right = new Node(0);

            Assert.Equal(1, Program.CalculateBinaryTreeHeight(testTreeOne));
        }

        [Fact]
        public void TestingWhiteBoardExampleTwo()
        {
            BinaryTree testTreeTwo = new BinaryTree();
            testTreeTwo.Root = new Node(0);
            testTreeTwo.Root.Left = new Node(0);
            testTreeTwo.Root.Right = new Node(0);
            testTreeTwo.Root.Left.Left = new Node(0);
            testTreeTwo.Root.Right.Right = new Node(0);
            testTreeTwo.Root.Left.Left.Right = new Node(0);

            Assert.Equal(3, Program.CalculateBinaryTreeHeight(testTreeTwo));
        }

        [Fact]
        public void TestingWhiteBoardExampleThree()
        {
            BinaryTree testTreeThree = new BinaryTree();

            Assert.Equal(0, Program.CalculateBinaryTreeHeight(testTreeThree));
        }
    }

    public class CalculateBinaryTreeLevelTestSuite
    {
        [Fact]
        public void TestingWhiteBoardExampleOne()
        {
            BinaryTree testTreeOne = new BinaryTree();
            testTreeOne.Root = new Node(0);
            testTreeOne.Root.Left = new Node(0);
            testTreeOne.Root.Right = new Node(0);

            Assert.Equal(2, Program.CalculateBinaryTreeLevel(testTreeOne));
        }

        [Fact]
        public void TestingWhiteBoardExampleTwo()
        {
            BinaryTree testTreeTwo = new BinaryTree();
            testTreeTwo.Root = new Node(0);
            testTreeTwo.Root.Left = new Node(0);
            testTreeTwo.Root.Right = new Node(0);
            testTreeTwo.Root.Left.Left = new Node(0);
            testTreeTwo.Root.Right.Right = new Node(0);
            testTreeTwo.Root.Left.Left.Right = new Node(0);

            Assert.Equal(4, Program.CalculateBinaryTreeLevel(testTreeTwo));
        }

        [Fact]
        public void TestingWhiteBoardExampleThree()
        {
            BinaryTree testTreeThree = new BinaryTree();

            Assert.Equal(0, Program.CalculateBinaryTreeLevel(testTreeThree));
        }
    }
}
