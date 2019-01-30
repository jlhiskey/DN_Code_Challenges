using System;
using Xunit;
using StacksAndQueues.Classes;
using BreadthFirstTraversal;
using Tree.Classes;
using System.Collections.Generic;

namespace BreadthFirstTraversalTestSuite
{
    public class UnitTest1
    {
        [Fact]
        public void TestWithBalancedTree()
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(1);
            testTree.Root.Left = new Node(2);
            testTree.Root.Right = new Node(3);
            testTree.Root.Left.Left = new Node(4);
            testTree.Root.Left.Right = new Node(5);
            testTree.Root.Right.Left = new Node(6);
            testTree.Root.Right.Right = new Node(7);

            List<int> actual = Program.BreadthFirstTraversal(testTree);
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestWithUnbalancedTree()
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(1);
            testTree.Root.Left = new Node(2);
            testTree.Root.Right = new Node(3);
            testTree.Root.Left.Right = new Node(4);
            testTree.Root.Right.Left = new Node(5);
            testTree.Root.Right.Left.Left = new Node(6);

            List<int> actual = Program.BreadthFirstTraversal(testTree);
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6 };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestWithEmptyTree()
        {
            BinaryTree testTree = new BinaryTree();
            
            List<int> actual = Program.BreadthFirstTraversal(testTree);
            List<int> expected = new List<int> { };

            Assert.Equal(expected, actual);
        }
    }
}
