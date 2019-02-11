using System;
using Xunit;
using Tree.Classes;
using IsBinaryTreeBalanced;

namespace IsBinaryTreeBalancedTestSuite
{
    public class IsBinaryTreeBalancedTestSuite
    {
        [Fact]
        public void TestingWhiteBoardExampleOne()
        {
            BinaryTree testTreeOne = new BinaryTree();
            testTreeOne.Root = new Node(0);
            testTreeOne.Root.Left = new Node(0);
            testTreeOne.Root.Right = new Node(0);

            Assert.True(Program.IsBinaryTreeBalanced(testTreeOne));
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

            Assert.False(Program.IsBinaryTreeBalanced(testTreeTwo));
        }

        [Fact]
        public void TestingWhiteBoardExampleThree()
        {
            BinaryTree testTreeThree = new BinaryTree();

            Assert.True(Program.IsBinaryTreeBalanced(testTreeThree));
        }
    }
}
