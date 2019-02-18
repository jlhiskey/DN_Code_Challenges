using System;
using Xunit;
using FibNum;

namespace FibNumTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestingNEqualsZero()
        {
            Assert.Equal(0, Program.FibNum(0));
        }
        [Fact]
        public void TestingNEqualsTwo()
        {
            Assert.Equal(1, Program.FibNum(2));
        }
        [Fact]
        public void TestingNEqualsNegSix()
        {
            Assert.Equal(-8, Program.FibNum(-6));
        }
        [Fact]
        public void TestingNEqualsTwelve()
        {
            Assert.Equal(144, Program.FibNum(12));
        }
        [Fact]
        public void TestingNEqualsFourtyFive()
        {
            Assert.Equal(1134903170, Program.FibNum(45));
        }
    }
}
