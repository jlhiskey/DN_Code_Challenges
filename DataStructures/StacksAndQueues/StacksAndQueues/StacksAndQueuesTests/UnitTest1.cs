using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StacksAndQueuesTests
{
    public class StackTestSuite
    {
        [Fact]
        public void TestingStackCreationWithNodeOne()
        {
            Node test = new Node(1);
            Stack testStack = new Stack(test);
            Assert.Equal(test, testStack.Peek());
        }


        [Fact]
        public void TestingStackCreationWithNodeTwo()
        {
            Node test = new Node(2);
            Stack testStack = new Stack(test);
            Assert.Equal(test, testStack.Peek());
        }

        [Fact]
        public void TestingStackCreationWithOutNode()
        {
           
            Stack testStack = new Stack();
            Assert.Null(testStack.Peek());
        }

        [Fact]
        public void TestingPushWithOneNode()
        {
            Stack testStack = new Stack();
            Node actual = testStack.Push(1);
            Node expected = testStack.Top;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestingPushWithTwoNodes()
        {
            Stack testStack = new Stack();
            testStack.Push(1);
            testStack.Push(2);
            Node actual = testStack.Push(3);
            Node expected = testStack.Top;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestingPushWithThreeNodes()
        {
            Stack testStack = new Stack();
            testStack.Push(1);
            testStack.Push(2);
            testStack.Push(3);
            Node actual = testStack.Push(4);
            Node expected = testStack.Top;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestingPopWithOneNode()
        {
            Stack testStack = new Stack();
            Node expected = testStack.Push(1);
            Node actual = testStack.Pop();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestingPopWithTwoNodes()
        {
            Stack testStack = new Stack();
            testStack.Push(1);
            Node expected = testStack.Push(2);
            testStack.Push(3);
            testStack.Pop();
            Node actual = testStack.Pop();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestingPopWithEmptyStack()
        {
            Stack testStack = new Stack();
            Assert.Null(testStack.Pop());
        }

        [Fact]
        public void TestingPeekWithOneNode()
        {
            Stack testStack = new Stack();
            Node expected = testStack.Push(1);
            Assert.Equal(expected, testStack.Peek());
        }

        [Fact]
        public void TestingPeekWithTwoNodes()
        {
            Stack testStack = new Stack();
            testStack.Push(1);
            Node expected = testStack.Push(2);
            Assert.Equal(expected, testStack.Peek());
        }

        [Fact]
        public void TestingPeekWithNoNodes()
        {
            Stack testStack = new Stack();
            
            Assert.Null(testStack.Peek());
        }

        [Fact]
        public void TestingGetSizeWithOneNode()
        {
            Stack testStack = new Stack();
            testStack.Push(1);
            Assert.Equal(1, testStack.GetSize());
        }

        [Fact]
        public void TestingGetSizeWithThreeNodes()
        {
            Stack testStack = new Stack();
            testStack.Push(1);
            testStack.Push(2);
            testStack.Push(3);
            Assert.Equal(3, testStack.GetSize());
        }

        [Fact]
        public void TestingGetSizeWithThreeNodesAndAPop()
        {
            Stack testStack = new Stack();
            testStack.Push(1);
            testStack.Push(2);
            testStack.Pop();
            testStack.Push(3);
            Assert.Equal(2, testStack.GetSize());
        }

        [Fact]
        public void TestingGetSizeWithNoNodes()
        {
            Stack testStack = new Stack();
            Assert.Equal(0, testStack.GetSize());
        }
    }
}