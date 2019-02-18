using System;
using Xunit;
using BinarySearch;

namespace XUnitTestProject1
{
    public class BinarySearchTest
    {
        [Fact]
        public void TestingWhenSearchValueIsGreaterThanMiddleIndex()
        {
            Assert.Equal(0, Program.BinarySearch(new int[5] { 2, 4, 5, 6, 8 }, 2));
        }
        [Fact]
        public void TestingWhenSearchValueIsLessThanMiddleIndex()
        {
            Assert.Equal(4, Program.BinarySearch(new int[5] { 2, 4, 5, 6, 8 }, 8));
        }
        [Fact]
        public void TestingWhenSearchValueCantBeFoundInInputArrayLowValue()
        {
            Assert.Equal(-1, Program.BinarySearch(new int[5] { 2, 4, 5, 6, 8 }, 1));
        }
        [Fact]
        public void TestingWhenSearchValueCantBeFoundInInputArrayHighValue()
        {
            Assert.Equal(-1, Program.BinarySearch(new int[5] { 2, 4, 5, 6, 8 }, 9));
        }
    }
}
