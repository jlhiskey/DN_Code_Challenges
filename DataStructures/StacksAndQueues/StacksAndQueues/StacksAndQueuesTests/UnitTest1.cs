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
    }
}
