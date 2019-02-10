using System;
using Xunit;
using Tree.Classes;
using CompareLeaves;

namespace CompareLeavesTestSuite
{
    public class CompareLeavesTests
    {
        [Fact]
        public void ClassExampleOneTrue()
        {
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

            Assert.True(Program.CompareLeaves(testTreeOne, testTreeTwo));
        }

        [Fact]
        public void ClassExampleTwoFalse()
        {
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

            Assert.False(Program.CompareLeaves(testTreeThree, testTreeFour));
        }

        [Fact]
        public void TwoEmptyTreesTrue()
        {
            BinaryTree testTreeThree = new BinaryTree();
            BinaryTree testTreeFour = new BinaryTree();
            
            Assert.True(Program.CompareLeaves(testTreeThree, testTreeFour));
        }


        [Fact]
        public void FirstTreeEmptyFalse()
        {
            BinaryTree testTreeThree = new BinaryTree();

            BinaryTree testTreeFour = new BinaryTree();
            testTreeFour.Root = new Node(0);
            testTreeFour.Root.Left = new Node(0);
            testTreeFour.Root.Right = new Node(0);
            testTreeFour.Root.Left.Left = new Node(0);
            testTreeFour.Root.Right.Left = new Node(0);
            testTreeFour.Root.Right.Right = new Node(0);
            testTreeFour.Root.Left.Left.Right = new Node(0);
            testTreeFour.Root.Right.Right.Left = new Node(0);

            Assert.False(Program.CompareLeaves(testTreeThree, testTreeFour));
        }

        [Fact]
        public void SecondTreeEmptyFalse()
        {
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

            Assert.False(Program.CompareLeaves(testTreeThree, testTreeFour));
        }
    }
}
