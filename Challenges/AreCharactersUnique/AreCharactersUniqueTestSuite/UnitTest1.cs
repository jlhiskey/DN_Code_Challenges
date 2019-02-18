using System;
using Xunit;
using AreCharactersUnique;

namespace AreCharactersUniqueTestSuite
{
    public class AreCharactersUniqueTestSuite
    {
        [Fact]
        public void AreCharactersUniqueUsing_ABCD()
        {
            Assert.True(Program.AreCharactersUnique("ABCD"));
        }

        [Fact]
        public void AreCharactersUniqueUsing_ABCA()
        {
            Assert.False(Program.AreCharactersUnique("ABCA"));
        }

        [Fact]
        public void AreCharactersUniqueUsing_AabCD()
        {
            Assert.True(Program.AreCharactersUnique("AabCD"));
        }
    }
}
