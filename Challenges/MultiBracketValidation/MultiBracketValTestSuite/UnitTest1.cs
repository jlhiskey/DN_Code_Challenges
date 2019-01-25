using System;
using Xunit;
using MultiBracketValidation;

namespace MultiBracketValTestSuite
{
    public class TestingMultiBracketValidation
    {
        [Fact]
        public void TestingExample1()
        {
            Assert.True(Program.MultiBracketValidation("{}"));
        }

        [Fact]
        public void TestingExample2()
        {
            Assert.True(Program.MultiBracketValidation("{}(){}"));
        }

        [Fact]
        public void TestingExample3()
        {
            Assert.True(Program.MultiBracketValidation("()[[Extra Characters]]"));
        }

        [Fact]
        public void TestingExample4()
        {
            Assert.True(Program.MultiBracketValidation("(){}[[]]"));
        }
        [Fact]
        public void TestingExample5()
        {
            Assert.True(Program.MultiBracketValidation("{}{Code}[Fellows](())"));
        }

        [Fact]
        public void TestingExample6()
        {
            Assert.False(Program.MultiBracketValidation("[({}]"));
        }

        [Fact]
        public void TestingExample7()
        {
            Assert.False(Program.MultiBracketValidation("(]("));
        }

        [Fact]
        public void TestingExample8()
        {
            Assert.False(Program.MultiBracketValidation("{(})"));
        }

    }
}
