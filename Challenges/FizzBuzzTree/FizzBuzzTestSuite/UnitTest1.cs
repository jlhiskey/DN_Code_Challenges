using System;
using Xunit;
using FizzBuzzTree.Classes;
using FizzBuzzTree;
using System.Collections.Generic;

namespace FizzBuzzTestSuite
{
    public class UnitTest1
    {
        [Fact]
        public void TestingTreeOne()
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node("15");
            testTree.Root.Left = new Node("3");
            testTree.Root.Right = new Node("5");
            testTree.Root.Left.Left = new Node("4");
            testTree.Root.Left.Right = new Node("7");

            BinaryTree actual = Program.FizzBuzzTree(testTree);
            List<string> actualValues = actual.InOrder();

            BinaryTree expected = new BinaryTree();
            expected.Root = new Node("FizzBuzz");
            expected.Root.Left = new Node("Fizz");
            expected.Root.Right = new Node("Buzz");
            expected.Root.Left.Left = new Node("4");
            expected.Root.Left.Right = new Node("7");
            List<string> expectedValues = expected.InOrder();

            Assert.Equal(expectedValues, actualValues);
        }

        [Fact]
        public void TestingTreeTwo()
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node("14");
            testTree.Root.Left = new Node("30");
            testTree.Root.Right = new Node("45");
            testTree.Root.Left.Left = new Node("6");
            testTree.Root.Left.Right = new Node("10");

            BinaryTree actual = Program.FizzBuzzTree(testTree);
            List<string> actualValues = actual.InOrder();

            BinaryTree expected = new BinaryTree();
            expected.Root = new Node("14");
            expected.Root.Left = new Node("FizzBuzz");
            expected.Root.Right = new Node("FizzBuzz");
            expected.Root.Left.Left = new Node("Fizz");
            expected.Root.Left.Right = new Node("Buzz");
            List<string> expectedValues = expected.InOrder();

            Assert.Equal(expectedValues, actualValues);
        }

        [Fact]
        public void TestingTreeThree()
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node("150");
            testTree.Root.Left = new Node("30");
            testTree.Root.Right = new Node("50");
            testTree.Root.Left.Left = new Node("40");
            testTree.Root.Left.Right = new Node("70");

            BinaryTree actual = Program.FizzBuzzTree(testTree);
            List<string> actualValues = actual.InOrder();

            BinaryTree expected = new BinaryTree();
            expected.Root = new Node("FizzBuzz");
            expected.Root.Left = new Node("FizzBuzz");
            expected.Root.Right = new Node("Buzz");
            expected.Root.Left.Left = new Node("Buzz");
            expected.Root.Left.Right = new Node("Buzz");
            List<string> expectedValues = expected.InOrder();

            Assert.Equal(expectedValues, actualValues);
        }
    }
}
