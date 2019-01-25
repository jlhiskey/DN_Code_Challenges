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
        public void Test1()
        {

        }
    }
}
