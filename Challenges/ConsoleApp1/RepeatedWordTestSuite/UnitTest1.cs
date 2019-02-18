using System;
using Xunit;
using RepeatedWord;

namespace RepeatedWordTestSuite
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("a", Program.RepeatedWord("A volcano is a volcano."));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal("party", Program.RepeatedWord("When is the Party? What party?"));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal("no repeated words", Program.RepeatedWord("Today is Monday."));
        }
    }
}
