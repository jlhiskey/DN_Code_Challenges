using System;
using Xunit;
using LinkedList.Classes;
using LLKthFromEnd;

namespace kthTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestingIfReturnsValueHead()
        {
            LList test = new LList();
            test.InsertAtHead(3);
            test.InsertAtHead(2);
            test.InsertAtHead(1);
            Assert.Equal(1, Program.KthFromEnd(test, 2));        
        }

        [Fact]
        public void TestingIfReturnsValueTail()
        {
            LList test = new LList();
            test.InsertAtHead(3);
            test.InsertAtHead(2);
            test.InsertAtHead(1);
            Assert.Equal(3, Program.KthFromEnd(test, 0));
        }

        [Fact]
        public void TestingIfReturnsValueMiddle()
        {
            LList test = new LList();
            test.InsertAtHead(3);
            test.InsertAtHead(2);
            test.InsertAtHead(1);
            Assert.Equal(2, Program.KthFromEnd(test, 1));
        }

        [Fact]
        public void TestingIfReturnsValueOutOfRange()
        {
            LList test = new LList();
            test.InsertAtHead(3);
            test.InsertAtHead(2);
            test.InsertAtHead(1);
            Assert.Equal(-404, Program.KthFromEnd(test, 12));
        }
    }
}
