using Hashtable.Classes;
using LeftJoin;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeftJoinTestSuite
{
    public class LeftJoinTestSuite
    {
        [Fact]
        public void TestingWithNoCollisions()
        {
            HashTable left = new HashTable(5);
            left.Add("Bob", "First");
            left.Add("Frank", "First");

            HashTable right = new HashTable(5);
            right.Add("Bob", "Second");
            right.Add("Jim", "Second");

            List<string> expected = new List<string>();
            expected.Add("Bob, First, Second");
            expected.Add("Frank, First, NULL");

            List<string> actual = Program.LeftJoin(left, right);

            Assert.Equal(expected, actual);
        }
    }
}
