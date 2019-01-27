using System;
using Xunit;
using Tree.Classes;
using System.Collections.Generic;

namespace TreeTestSuite
{
    public class BinaryTreeTestSuite
    {
        [Theory]
        [InlineData (1, 2, 3, 4, 5)]
        [InlineData(100, 75, 93, 17, 45)]
        [InlineData(12, 4, 2, 8, 1)]
        public void TestingPreOrder(int valueOne, int valueTwo, int valueThree, int valueFour, int valueFive)
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(valueOne);
            testTree.Root.Left = new Node(valueTwo);
            testTree.Root.Right = new Node(valueThree);
            testTree.Root.Left.Left = new Node(valueFour);
            testTree.Root.Left.Right = new Node(valueFive);

            List<int> expectedValues = new List<int> { valueOne, valueTwo, valueFour, valueFive, valueThree };

            Assert.Equal(expectedValues, testTree.PreOrder());
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 5)]
        [InlineData(100, 75, 93, 17, 45)]
        [InlineData(12, 4, 2, 8, 1)]
        public void TestingInOrder(int valueOne, int valueTwo, int valueThree, int valueFour, int valueFive)
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(valueOne);
            testTree.Root.Left = new Node(valueTwo);
            testTree.Root.Right = new Node(valueThree);
            testTree.Root.Left.Left = new Node(valueFour);
            testTree.Root.Left.Right = new Node(valueFive);

            List<int> expectedValues = new List<int> { valueFour, valueTwo, valueFive, valueOne, valueThree };

            Assert.Equal(expectedValues, testTree.InOrder());
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 5)]
        [InlineData(100, 75, 93, 17, 45)]
        [InlineData(12, 4, 2, 8, 1)]
        public void TestingPostOrder(int valueOne, int valueTwo, int valueThree, int valueFour, int valueFive)
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(valueOne);
            testTree.Root.Left = new Node(valueTwo);
            testTree.Root.Right = new Node(valueThree);
            testTree.Root.Left.Left = new Node(valueFour);
            testTree.Root.Left.Right = new Node(valueFive);

            List<int> expectedValues = new List<int> { valueFour, valueFive, valueTwo, valueThree, valueOne };

            Assert.Equal(expectedValues, testTree.PostOrder());
        }
    }
}
