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
    }
}
