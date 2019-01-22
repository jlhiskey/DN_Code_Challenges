using System;
using Xunit;
using StacksAndQueues.Classes;
using QueueWithStacks.Classes;

namespace QueueWithStacksTestSuite
{
    public class TestingPseudoQueue
    {
        [Fact]
        public void TestingCreatingPseudoQueueOne()
        {
            PsuedoQueue testQueue = new PsuedoQueue(1);
            Assert.Equal(1, testQueue.Dequeue());
        }

        [Fact]
        public void TestingCreatingPseudoQueueTwo()
        {
            PsuedoQueue testQueue = new PsuedoQueue(2);
            Assert.Equal(2, testQueue.Dequeue());
        }

        [Fact]
        public void TestingCreatingPseudoQueueThree()
        {
            PsuedoQueue testQueue = new PsuedoQueue(3);
            Assert.Equal(3, testQueue.Dequeue());
        }

        [Fact]
        public void TestingEnqueueWithOneNode()
        {
            PsuedoQueue testQueue = new PsuedoQueue(1);
            testQueue.Enqueue(2);
            Assert.Equal(1, testQueue.Dequeue());
        }

        [Fact]
        public void TestingEnqueueWithTwoNodes()
        {
            PsuedoQueue testQueue = new PsuedoQueue(1);
            testQueue.Enqueue(2);
            testQueue.Enqueue(3);
            Assert.Equal(1, testQueue.Dequeue());
        }

        [Fact]
        public void TestingEnqueueWithThreeNode()
        {
            PsuedoQueue testQueue = new PsuedoQueue(1);
            testQueue.Enqueue(2);
            testQueue.Enqueue(3);
            testQueue.Enqueue(4);
            Assert.Equal(1, testQueue.Dequeue());
        }

        [Fact]
        public void TestingDequeueWithOneNode()
        {
            PsuedoQueue testQueue = new PsuedoQueue(1);
            Assert.Equal(1, testQueue.Dequeue());
        }

        [Fact]
        public void TestingDequeueWithTwoNodes()
        {
            PsuedoQueue testQueue = new PsuedoQueue(1);
            testQueue.Enqueue(2);
            testQueue.Dequeue();
            Assert.Equal(2, testQueue.Dequeue());
        }

        [Fact]
        public void TestingDequeueWithThreeNode()
        {
            PsuedoQueue testQueue = new PsuedoQueue(1);
            testQueue.Enqueue(2);
            testQueue.Enqueue(3);
            testQueue.Dequeue();
            testQueue.Dequeue();
            Assert.Equal(3, testQueue.Dequeue());
        }

        [Fact]
        public void TestingDequeueThenEnqueueThenDequeue()
        {
            PsuedoQueue testQueue = new PsuedoQueue(1);
            testQueue.Dequeue();
            testQueue.Enqueue(2);
            Assert.Equal(2, testQueue.Dequeue());
        }

        [Fact]
        public void TestingManyDequeuesAndEnqueues()
        {
            PsuedoQueue testQueue = new PsuedoQueue(1);
            testQueue.Dequeue();
            testQueue.Enqueue(2);
            testQueue.Enqueue(3);
            testQueue.Dequeue();
            testQueue.Enqueue(4);
            Assert.Equal(3, testQueue.Dequeue());
        }

    }
}
