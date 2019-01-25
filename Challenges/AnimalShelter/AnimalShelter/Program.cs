using System;
using AnimalShelter.Classes;

namespace AnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalShelterClass test = new AnimalShelterClass("bob");
            Console.WriteLine("//Initial Goal");
            Console.WriteLine("//Enqueue");
            test.Enqueue(AnimalType.cat, "Gregor");
            test.Enqueue(AnimalType.cat, "BAMF");
            test.Enqueue(AnimalType.dog, "Harley");
            Console.WriteLine("//Dequeue");
            test.Dequeue(AnimalType.cat);
            test.Dequeue(AnimalType.cat);
            Console.WriteLine("//Stretch Goal Case Where there arent any cat's left");
            test.Dequeue(AnimalType.cat);
            Console.WriteLine("//Empty Animal Shelter Case");
            test.Dequeue(AnimalType.cat);
            Console.ReadLine();
        }
        
    }
}
