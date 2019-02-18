using AnimalShelter.Classes;
using System;
using Xunit;

namespace AnimalShelterTestSuite
{
    public class TestingEnqueue
    {
        [Fact]
        public void TestingEnqueueOneAnimalType()
        {
            AnimalShelterClass test = new AnimalShelterClass("Test Shelter");
            
            Assert.Equal("Gregor", test.Enqueue(AnimalType.cat, "Gregor").Name);
        }

        [Fact]
        public void TestingEnqueueTwoAnimalTypes()
        {
            AnimalShelterClass test = new AnimalShelterClass("Test Shelter");
            test.Enqueue(AnimalType.dog, "Harley");
            Assert.Equal("Gregor", test.Enqueue(AnimalType.cat, "Gregor").Name);
        }

        [Fact]
        public void TestingEnqueueThreeAnimalsTwoTypes()
        {

            AnimalShelterClass test = new AnimalShelterClass("Test Shelter");
            test.Enqueue(AnimalType.dog, "Harley");
            test.Enqueue(AnimalType.cat, "BAMF");
            Assert.Equal("Gregor", test.Enqueue(AnimalType.cat, "Gregor").Name);
        }
    }

    public class TestingDequeue
    {
        [Fact]
        public void TestingOneCatEnqueueOneCatDequeue()
        {
            AnimalShelterClass test = new AnimalShelterClass("Test Shelter");
            test.Enqueue(AnimalType.cat, "Gregor");
            Assert.Equal("Gregor", test.Dequeue(AnimalType.cat).Name);
        }

        [Fact]
        public void TestingOneDogEnqueueOneDogDequeue()
        {
            AnimalShelterClass test = new AnimalShelterClass("Test Shelter");
            test.Enqueue(AnimalType.dog, "Harley");
            Assert.Equal("Harley", test.Dequeue(AnimalType.dog).Name);
        }

        [Fact]
        public void TestingOneDogOneCatEnqueueOneDogDequeue()
        {
            AnimalShelterClass test = new AnimalShelterClass("Test Shelter");
            test.Enqueue(AnimalType.dog, "Harley");
            test.Enqueue(AnimalType.cat, "Gregor");
            Assert.Equal("Harley", test.Dequeue(AnimalType.dog).Name);
        }

        [Fact]
        public void TestingOneDogOneCatEnqueueOneCatDequeue()
        {
            AnimalShelterClass test = new AnimalShelterClass("Test Shelter");
            test.Enqueue(AnimalType.dog, "Harley");
            test.Enqueue(AnimalType.cat, "Gregor");
            Assert.Equal("Gregor", test.Dequeue(AnimalType.cat).Name);
        }

        [Fact]
        public void TestingOneDogTwoCatEnqueueOneCatDequeueOneDogDequeue()
        {
            AnimalShelterClass test = new AnimalShelterClass("Test Shelter");
            test.Enqueue(AnimalType.dog, "Harley");
            test.Enqueue(AnimalType.cat, "Gregor");
            test.Enqueue(AnimalType.cat, "BAMF");
            test.Dequeue(AnimalType.cat);
            Assert.Equal("Harley", test.Dequeue(AnimalType.dog).Name);
        }

        [Fact]
        public void TestingDequeueOnEmptyShelter()
        {
            AnimalShelterClass test = new AnimalShelterClass("Test Shelter");
            
            Assert.Null(test.Dequeue(AnimalType.dog));
        }

        [Fact]
        public void TestingStretchGoalIfDequeueTypeIsntInShelterGiveOldest()
        {
            AnimalShelterClass test = new AnimalShelterClass("Test Shelter");
            test.Enqueue(AnimalType.cat, "Gregor");
            test.Enqueue(AnimalType.cat, "BAMF");
            test.Enqueue(AnimalType.dog, "Harley");
            test.Dequeue(AnimalType.cat);
            test.Dequeue(AnimalType.cat);
            Assert.Equal("Harley", test.Dequeue(AnimalType.cat).Name);
        }
    }
}
