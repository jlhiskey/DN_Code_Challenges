using System;
using Xunit;
using Hashtable.Classes;

namespace HashtableTestSuite
{
    public class HashtableTestSuite
    {
        //Added seeded Hashtable builder for use in GET, CONTAIN and DELETE test suites.
        public static HashTable BuildHashTable()
        {
            HashTable testHashTable = new HashTable(5);
            testHashTable.Add("Pioneer Square", 98104);
            testHashTable.Add("Alki Beach", 98116);
            testHashTable.Add("U District", 98105);

            return testHashTable;
        }

        public class HasherTestSuite
        {
            HashTable testHashTable = new HashTable(5);
            [Fact]
            public void TestingHasherOne()
            {
                
                Assert.Equal(1, testHashTable.Hasher("Pioneer Square"));               
            }

            [Fact]
            public void TestingHasherTwo()
            {
                Assert.Equal(1, testHashTable.Hasher("Alki Beach"));
            }

            [Fact]
            public void TestingHasherThree()
            {
                Assert.Equal(0, testHashTable.Hasher("U District"));
            }
        }

        public class AddTestSuite
        {
            HashTable testHashTable = new HashTable(5);

            [Fact]
            public void TestingAddOne()
            {
                testHashTable.Add("Pioneer Square", 98104);
                Assert.True(testHashTable.Contains("Pioneer Square"));
            }

            [Fact]
            public void TestingAddTwo()
            {
                testHashTable.Add("U District", 98105);
                Assert.True(testHashTable.Contains("U District"));
            }

            [Fact]
            public void TestingAddWithCollision()
            {
                testHashTable.Add("Pioneer Square", 98104);
                
                //Proving that both keys will index to the same value.
                if (testHashTable.Hasher("Pioneer Square") == testHashTable.Hasher("Alki Beach"))
                {
                    testHashTable.Add("Alki Beach", 98116);
                }
                Assert.True(testHashTable.Contains("Alki Beach"));
            }
        }

        public class GetTestSuite
        {
            HashTable testHashTable = BuildHashTable();

            [Fact]
            public void TestingGet()
            {
                Assert.Equal(98105, testHashTable.Get("U District"));
            }

            [Fact]
            public void TestingGetFromCollisionOne()
            {
                Assert.Equal(98104, testHashTable.Get("Pioneer Square"));
            }

            [Fact]
            public void TestingGetFromCollisionTwo()
            {
                Assert.Equal(98116, testHashTable.Get("Alki Beach"));
            }

            [Fact]
            public void TestingGetNull()
            {
                Assert.Null(testHashTable.Get("Chucky Cheese"));
            }

        }

        public class ContainsTestSuite
        {
            HashTable testHashTable = BuildHashTable();

            [Fact]
            public void TestingContains()
            {
                Assert.True(testHashTable.Contains("U District"));
            }

            [Fact]
            public void TestingContainsFromCollisionOne()
            {
                Assert.True(testHashTable.Contains("Pioneer Square"));
            }

            [Fact]
            public void TestingContainsFromCollisionTwo()
            {
                Assert.True(testHashTable.Contains("Alki Beach"));
            }

            [Fact]
            public void TestingContainsNull()
            {
                Assert.False(testHashTable.Contains("Chucky Cheese"));
            }
        }

        public class RemoveTestSuite
        {

            HashTable testHashTable = BuildHashTable();

            [Fact]
            public void TestingRemove()
            {
                //Proving that hashtable contains key before removing.
                if (testHashTable.Contains("U District"))
                {
                    testHashTable.Remove("U District");
                } 
                Assert.False(testHashTable.Contains("U District"));
            }

            [Fact]
            public void TestingRemoveWithCollisionOne()
            {
                //Proving that hashtable contains key before removing.
                if (testHashTable.Contains("Alki Beach"))
                {
                    testHashTable.Remove("Alki Beach");
                }
                Assert.False(testHashTable.Contains("Alki Beach"));
            }

            [Fact]
            public void TestingRemoveWithCollisionTwo()
            {
                //Proving that hashtable contains key before removing.
                if (testHashTable.Contains("Pioneer Square"))
                {
                    testHashTable.Remove("Pioneer Square");
                }
                Assert.False(testHashTable.Contains("Pioneer Square"));
            }

            [Fact]
            public void TestingRemoveNull()
            {
                testHashTable.Remove("Chucky Cheese");
               
                Assert.False(testHashTable.Contains("Chucky Cheese"));
            }

        }
    }
}
