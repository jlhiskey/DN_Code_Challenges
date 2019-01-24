using System;
using AnimalShelter.Classes;

namespace AnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalShelterClass test = new AnimalShelterClass("bob");
            test.Enqueue(AnimalType.cat, "Gregor");
            test.Enqueue(AnimalType.cat, "BAMF");
            test.Enqueue(AnimalType.dog, "Harley");
            test.Dequeue(AnimalType.cat);
            test.Dequeue(AnimalType.cat);
            Animal testOne = test.Dequeue(AnimalType.cat);
        }
        
    }
}
