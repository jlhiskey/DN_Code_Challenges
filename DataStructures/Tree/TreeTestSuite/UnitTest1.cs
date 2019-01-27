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

    public class BinarySearchTreeTestSuite
    {
        [Fact]
        public void TestingAdd()
        {
            BinarySearchTree testBST = new BinarySearchTree();
            testBST.Add(4);
            testBST.Add(2);
            testBST.Add(6);
            testBST.Add(1);
            testBST.Add(3);
            testBST.Add(5);
            testBST.Add(7);

            List<int> expectedValues = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            Assert.Equal(expectedValues, testBST.InOrder());
        }

        [Fact]
        public void TestingAddTwo()
        {
            BinarySearchTree testBST = new BinarySearchTree();
            testBST.Add(10);
            testBST.Add(2);
            testBST.Add(6);
            testBST.Add(1);
            testBST.Add(3);
            testBST.Add(5);
            testBST.Add(7);

            List<int> expectedValues = new List<int> { 1, 2, 3, 5, 6, 7, 10 };
            Assert.Equal(expectedValues, testBST.InOrder());
        }

        [Fact]
        public void TestingAddThree()
        {
            BinarySearchTree testBST = new BinarySearchTree();
            testBST.Add(14);
            testBST.Add(2);
            testBST.Add(99);
            testBST.Add(1);
            testBST.Add(3);
            testBST.Add(56);
            testBST.Add(12);

            List<int> expectedValues = new List<int> { 1, 2, 3, 12, 14, 56, 99 };
            Assert.Equal(expectedValues, testBST.InOrder());
        }

        [Fact]
        public void TestingContainsTrue()
        {
            BinarySearchTree testBST = new BinarySearchTree();
            testBST.Add(1);
            testBST.Add(2);
            testBST.Add(3);
            testBST.Add(4);
            testBST.Add(5);
            testBST.Add(6);
            testBST.Add(7);

            Assert.True(testBST.Contains(1));
        }

        [Fact]
        public void TestingContainsTrueTwo()
        {
            BinarySearchTree testBST = new BinarySearchTree();
            testBST.Add(1);
            testBST.Add(2);
            testBST.Add(3);
            testBST.Add(4);
            testBST.Add(5);
            testBST.Add(6);
            testBST.Add(7);

            Assert.True(testBST.Contains(7));
        }

        [Fact]
        public void TestingContainsFalse()
        {
            BinarySearchTree testBST = new BinarySearchTree();
            testBST.Add(1);
            testBST.Add(2);
            testBST.Add(3);
            testBST.Add(4);
            testBST.Add(5);
            testBST.Add(6);
            testBST.Add(7);

            Assert.False(testBST.Contains(8));
        }

        [Fact]
        public void TestingContainsFalseTwo()
        {
            BinarySearchTree testBST = new BinarySearchTree();
            testBST.Add(1);
            testBST.Add(2);
            testBST.Add(3);
            testBST.Add(4);
            testBST.Add(5);
            testBST.Add(6);
            testBST.Add(7);

            Assert.False(testBST.Contains(99));
        }
    }
}
