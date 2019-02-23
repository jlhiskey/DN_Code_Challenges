using System;
using Xunit;
using MostCommonWord;

namespace XUnitTestProject1
{
    public class MostCommonWordTestSuite
    {
        [Fact]
        public void TestingOneDoubleRepeatingWord()
        {
            Assert.Equal("far", Program.MostCommonWord("In a galaxy far far away"));
        }

        [Fact]
        public void TestingThreeDoubleRepeatingWords()
        {
            Assert.Equal("do", Program.MostCommonWord("No. Try not. Do or do not. There is no try."));
        }

        [Fact]
        public void TestingAllUniqueWords()
        {
            Assert.Equal("I", Program.MostCommonWord("I am unique"));
        }

       
    }
}
