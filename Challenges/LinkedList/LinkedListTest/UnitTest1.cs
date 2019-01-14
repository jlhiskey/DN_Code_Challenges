using System;
using Xunit;
using LinkedList.Classes;

namespace LinkedListTest
{
    public class TestingInsertAtHead
    {
        [Fact]
        public void InsertingOneValueAndCheckingHeadValue()
        {
            //Makes a new linked list
            LList test = new LList();

            //Inserts new node into linked list.
            test.InsertAtHead(1);

            //prints out an array with all nodes in list starting with head value.
            int[] listValues = test.PrintValues();
            //Expected head value 
            int expectedValue = 1;
            //Actual head value
            int actualValue = listValues[0];
            //Checks to see if expected equals actual.
            Assert.Equal(expectedValue, actualValue);
        }
        [Fact]
        public void InsertingTwoValuesAndCheckingHeadValue()
        {
            //Makes a new linked list
            LList test = new LList();

            //Inserts new node into linked list.
            test.InsertAtHead(1);
            test.InsertAtHead(2);

            //prints out an array with all nodes in list starting with head value.
            int[] listValues = test.PrintValues();
            //Expected head value 
            int expectedValue = 2;
            //Actual head value
            int actualValue = listValues[0];
            //Checks to see if expected equals actual.
            Assert.Equal(expectedValue, actualValue);
        }
        [Fact]
        public void InsertingThreeValuesAndCheckingHeadValue()
        {
            //Makes a new linked list
            LList test = new LList();

            //Inserts new node into linked list.
            test.InsertAtHead(1);
            test.InsertAtHead(2);
            test.InsertAtHead(3);

            //prints out an array with all nodes in list starting with head value.
            int[] listValues = test.PrintValues();
            //Expected head value 
            int expectedValue = 3;
            //Actual head value
            int actualValue = listValues[0];
            //Checks to see if expected equals actual.
            Assert.Equal(expectedValue, actualValue);
        }
    }

    public class TestingIncludes
    {
        [Fact]
        public void TestingValueAtHead()
        {
            //Makes a new linked list
            LList test = new LList();

            //Inserts new node into linked list.
            test.InsertAtHead(1);
            test.InsertAtHead(2);
            test.InsertAtHead(3);

            Assert.True(test.Includes(3));
        }
        [Fact]
        public void TestingValueAtTail()
        {
            //Makes a new linked list
            LList test = new LList();

            //Inserts new node into linked list.
            test.InsertAtHead(1);
            test.InsertAtHead(2);
            test.InsertAtHead(3);

            Assert.True(test.Includes(1));
        }
        [Fact]
        public void TestingNoValueFound()
        {
            //Makes a new linked list
            LList test = new LList();

            //Inserts new node into linked list.
            test.InsertAtHead(1);
            test.InsertAtHead(2);
            test.InsertAtHead(3);

            Assert.False(test.Includes(4));
        }
    }

    public class TestingPrint
    {
        [Fact]
        public void TestingThreeNodeLinkedList()
        {
            //Makes a new linked list
            LList test = new LList();

            //Inserts new node into linked list.
            test.InsertAtHead(1);
            test.InsertAtHead(2);
            test.InsertAtHead(3);

            //prints out an array with all nodes in list starting with head value.
            int[] actualValues = test.PrintValues();
            int[] expectedValues = new int[] { 3, 2, 1 };
            //Checks to see if expected equals actual.
            Assert.Equal(expectedValues, actualValues);
        }
        [Fact]
        public void TestingThreeIdenticalNodeLinkedList()
        {
            //Makes a new linked list
            LList test = new LList();

            //Inserts new node into linked list.
            test.InsertAtHead(1);
            test.InsertAtHead(1);
            test.InsertAtHead(1);

            //prints out an array with all nodes in list starting with head value.
            int[] actualValues = test.PrintValues();
            int[] expectedValues = new int[] { 1, 1, 1 };
            //Checks to see if expected equals actual.
            Assert.Equal(expectedValues, actualValues);
        }
        [Fact]
        public void TestingEmptyLinkedList()
        {
            //Makes a new linked list
            LList test = new LList();
            
            //prints out an array with all nodes in list starting with head value.
            int[] actualValues = test.PrintValues();
            int[] expectedValues = new int[] {};
            //Checks to see if expected equals actual.
            Assert.Equal(expectedValues, actualValues);
        }
    }
}
