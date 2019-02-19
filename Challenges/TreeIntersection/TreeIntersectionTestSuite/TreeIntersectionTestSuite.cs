using System;
using Xunit;
using Tree.Classes;
using TreeIntersection;
using System.Collections.Generic;

namespace TreeIntersectionTestSuite
{
    public class TreeIntersectionTestSuite
    {
        [Fact]
        public void Test1()
        {
            BinaryTree testTreeOne = new BinaryTree();
            testTreeOne.Root = new Node(1);
            testTreeOne.Root.Left = new Node(2);
            testTreeOne.Root.Right = new Node(3);

            BinaryTree testTreeTwo = new BinaryTree();
            testTreeTwo.Root = new Node(4);
            testTreeTwo.Root.Left = new Node(1);
            testTreeTwo.Root.Right = new Node(2);

            List<int> expected = new List<int> { 1, 2 };
            List<int> actual = Program.TreeIntersection(testTreeOne, testTreeTwo);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            BinaryTree testTreeOne = new BinaryTree();
            testTreeOne.Root = new Node(1);
            testTreeOne.Root.Left = new Node(2);
            testTreeOne.Root.Left.Left = new Node(3);

            BinaryTree testTreeTwo = new BinaryTree();
            testTreeTwo.Root = new Node(1);
            testTreeTwo.Root.Left = new Node(2);
            testTreeTwo.Root.Right = new Node(3);

            List<int> expected = new List<int> { 1, 2, 3 };
            List<int> actual = Program.TreeIntersection(testTreeOne, testTreeTwo);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            BinaryTree testTreeOne = new BinaryTree();
            testTreeOne.Root = new Node(1);
            testTreeOne.Root.Left = new Node(2);
            testTreeOne.Root.Left.Left = new Node(3);

            BinaryTree testTreeTwo = new BinaryTree();
            testTreeTwo.Root = new Node(4);
            testTreeTwo.Root.Left = new Node(5);
            testTreeTwo.Root.Right = new Node(6);

            List<int> expected = new List<int>();
            List<int> actual = Program.TreeIntersection(testTreeOne, testTreeTwo);

            Assert.Equal(expected, actual);
        }
    }
}
