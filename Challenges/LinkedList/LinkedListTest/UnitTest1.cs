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
        public void Test1()
        {

        }
        [Fact]
        public void Test2()
        {

        }
        [Fact]
        public void Test3()
        {

        }
    }
}
