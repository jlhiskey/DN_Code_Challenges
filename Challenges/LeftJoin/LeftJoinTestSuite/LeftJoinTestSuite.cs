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
            //Making sure there are no collisions by adding 50 buckets for 2 data points
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

        [Fact]
        public void TestingWithCollisions()
        {
            //Making sure there are collisions by adding one bucket with 2 data points.
            HashTable left = new HashTable(1);
            left.Add("Bob", "First");
            left.Add("Frank", "First");

            HashTable right = new HashTable(1);
            right.Add("Bob", "Second");
            right.Add("Jim", "Second");

            List<string> expected = new List<string>();
            expected.Add("Bob, First, Second");
            expected.Add("Frank, First, NULL");

            List<string> actual = Program.LeftJoin(left, right);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestingWithAdditionalData()
        {
            HashTable left = new HashTable(50);
            left.Add("Bob", "First");
            left.Add("Frank", "First");
            left.Add("JimBob", "Crab Cakes");
            left.Add("Wu", "Tang");

            HashTable right = new HashTable(5);
            right.Add("Bob", "Second");
            right.Add("Jim", "Second");
            right.Add("JimBob", "Are Tasty");
            right.Add("Wu", "Clan");

            List<string> expected = new List<string>();
            expected.Add("Frank, First, NULL");
            expected.Add("Bob, First, Second");
            expected.Add("JimBob, Crab Cakes, Are Tasty");
            expected.Add("Wu, Tang, Clan");

            List<string> actual = Program.LeftJoin(left, right);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestingWithNoRightData()
        {
            HashTable left = new HashTable(50);
            left.Add("Bob", "First");
            left.Add("Frank", "First");
            left.Add("JimBob", "Crab Cakes");
            left.Add("Wu", "Tang");

            HashTable right = new HashTable(5);

            List<string> expected = new List<string>();
            expected.Add("Frank, First, NULL");
            expected.Add("Bob, First, NULL");
            expected.Add("JimBob, Crab Cakes, NULL");
            expected.Add("Wu, Tang, NULL");

            List<string> actual = Program.LeftJoin(left, right);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestingWithNoLeftData()
        {
            HashTable left = new HashTable(1);           

            HashTable right = new HashTable(5);
            right.Add("Bob", "Second");
            right.Add("Jim", "Second");
            right.Add("JimBob", "Are Tasty");
            right.Add("Wu", "Clan");

            List<string> expected = new List<string>();
            
            List<string> actual = Program.LeftJoin(left, right);

            Assert.Equal(expected, actual);
        }
    }
}
