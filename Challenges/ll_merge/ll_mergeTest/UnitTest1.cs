using System;
using Xunit;
using LinkedList.Classes;
using ll_merge;

namespace ll_mergeTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestingTwoListsOfEvenLength()
        {
            LList testList = new LList();

            testList.InsertAtHead(5);
            testList.InsertAtHead(3);
            testList.InsertAtHead(1);

            LList testList2 = new LList();
            
            testList2.InsertAtHead(6);
            testList2.InsertAtHead(4);
            testList2.InsertAtHead(2);

            LList expected = new LList();
            expected.InsertAtHead(6);
            expected.InsertAtHead(5);
            expected.InsertAtHead(4);
            expected.InsertAtHead(3);
            expected.InsertAtHead(2);
            expected.InsertAtHead(1);

            int[] expectedResults = expected.PrintValues();

            LList actual = Program.Merge(testList, testList2);

            int[] actualResults = actual.PrintValues();

            Assert.Equal(expectedResults, actualResults);
        }

        [Fact]
        public void TestingTwoListsWhereLL1IsLongerLength()
        {
            LList testList = new LList();
            testList.InsertAtHead(7);
            testList.InsertAtHead(5);
            testList.InsertAtHead(3);
            testList.InsertAtHead(1);

            LList testList2 = new LList();

            testList2.InsertAtHead(6);
            testList2.InsertAtHead(4);
            testList2.InsertAtHead(2);

            LList expected = new LList();
            expected.InsertAtHead(7);
            expected.InsertAtHead(6);
            expected.InsertAtHead(5);
            expected.InsertAtHead(4);
            expected.InsertAtHead(3);
            expected.InsertAtHead(2);
            expected.InsertAtHead(1);

            int[] expectedResults = expected.PrintValues();

            LList actual = Program.Merge(testList, testList2);

            int[] actualResults = actual.PrintValues();

            Assert.Equal(expectedResults, actualResults);
        }

        [Fact]
        public void TestingTwoListsWhereLL2IsLongerLength()
        {
            LList testList = new LList();
            testList.InsertAtHead(5);
            testList.InsertAtHead(3);
            testList.InsertAtHead(1);

            LList testList2 = new LList();
            testList2.InsertAtHead(7);
            testList2.InsertAtHead(6);
            testList2.InsertAtHead(4);
            testList2.InsertAtHead(2);

            LList expected = new LList();
            expected.InsertAtHead(7);
            expected.InsertAtHead(6);
            expected.InsertAtHead(5);
            expected.InsertAtHead(4);
            expected.InsertAtHead(3);
            expected.InsertAtHead(2);
            expected.InsertAtHead(1);

            int[] expectedResults = expected.PrintValues();

            LList actual = Program.Merge(testList, testList2);

            int[] actualResults = actual.PrintValues();

            Assert.Equal(expectedResults, actualResults);
        }

        [Fact]
        public void TestingTwoListsWhereLL1IsEmpty()
        {
            LList testList = new LList();

            LList testList2 = new LList();
            testList2.InsertAtHead(4);
            testList2.InsertAtHead(3);
            testList2.InsertAtHead(2);
            testList2.InsertAtHead(1);

            LList expected = new LList();
           
            expected.InsertAtHead(4);
            expected.InsertAtHead(3);
            expected.InsertAtHead(2);
            expected.InsertAtHead(1);

            int[] expectedResults = expected.PrintValues();

            LList actual = Program.Merge(testList, testList2);

            int[] actualResults = actual.PrintValues();

            Assert.Equal(expectedResults, actualResults);
        }

        [Fact]
        public void TestingTwoListsWhereLL2IsEmpty()
        {
            LList testList = new LList();
            testList.InsertAtHead(4);
            testList.InsertAtHead(3);
            testList.InsertAtHead(2);
            testList.InsertAtHead(1);

            LList testList2 = new LList();
            

            LList expected = new LList();

            expected.InsertAtHead(4);
            expected.InsertAtHead(3);
            expected.InsertAtHead(2);
            expected.InsertAtHead(1);

            int[] expectedResults = expected.PrintValues();

            LList actual = Program.Merge(testList, testList2);

            int[] actualResults = actual.PrintValues();

            Assert.Equal(expectedResults, actualResults);
        }

        [Fact]
        public void TestingTwoListsWhereBothLLAreEmpty()
        {
            LList testList = new LList();
            
            LList testList2 = new LList();

            Assert.Null(Program.Merge(testList, testList2));
        }
    }
}

