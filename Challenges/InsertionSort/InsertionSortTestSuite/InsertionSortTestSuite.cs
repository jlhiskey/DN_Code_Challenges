using System;
using Xunit;
using InsertionSort;

namespace InsertionSortTestSuite
{
    public class InsertionSortTestSuite
    {
        [Fact]
        public void TestInsertionSort1()
        {
            int[] testArray = new int[] { 1, 3, 5, 2, 4 };

            int[] expected = new int[] { 1, 2, 3, 4, 5 };

            Assert.Equal(expected, Program.InsertionSort(testArray));
        }

        [Fact]
        public void TestInsertionSort2()
        {
            int[] testArray = new int[] { 1, 2, 3, 4, 5 };

            int[] expected = new int[] { 1, 2, 3, 4, 5 };

            Assert.Equal(expected, Program.InsertionSort(testArray));
        }

        [Fact]
        public void TestInsertionSort3()
        {
            int[] testArray = new int[] { 5, 4, 3, 2, 1 };

            int[] expected = new int[] { 1, 2, 3, 4, 5 };

            Assert.Equal(expected, Program.InsertionSort(testArray));
        }

        [Fact]
        public void TestInsertionSort4()
        {
            int[] testArray = new int[]{};

            int[] expected = new int[] {};

            Assert.Equal(expected, Program.InsertionSort(testArray));
        }

        [Fact]
        public void TestInsertionSort5()
        {
            int[] testArray = new int[]{1};

            int[] expected = new int[] {1};

            Assert.Equal(expected, Program.InsertionSort(testArray));
        }
    }
}
