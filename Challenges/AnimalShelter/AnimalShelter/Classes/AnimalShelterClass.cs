using StacksAndQueues.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Classes
{
    /// <summary>
    /// Uses the Animal class hiearchy and Queue class.
    /// </summary>
    public class AnimalShelterClass
    {
        
        string Name { get; set; }

        Queue animalShelter = new Queue();
        Queue helperShelter = new Queue();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public AnimalShelterClass(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Add an animal to the animalShelter queue using enum AnimalType and string name. Returns the animal from the animalShelter
        /// </summary>
        /// <param name="animal"></param>
        /// <param name="name"></param>
        /// <returns>Animal from animalShelter</returns>
        public Animal Enqueue(AnimalType animal, string name)
        {
            if (animal == AnimalType.cat)
            {
                Cat newCat = new Cat(name);
                Animal result = animalShelter.Enqueue(newCat);
                return result;
            }
            else
            {
                Dog newDog = new Dog(name);
                Animal result = animalShelter.Enqueue(newDog);
                return result;
            }           
        }

        /// <summary>
        /// Checks animalShelter for oldest animal of enum AnimalType. If found will return oldest Animal of AnimalType else it will return oldest Animal in animalShelter.
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public Animal Dequeue(AnimalType animal)
        {
            Animal adoptedAnimal = new Cat("not animal");
            bool foundAnimal = false;
            // Will return null if animal shelter is empty.
            if (animalShelter.Peek() == null)
            {
                return null;
            }
            // Checks to see if the animal at the front of the line equals the search animal and returns it or if the animal shelter only has one animal returns it. Optimized so that you dont have to flop animals to helper stack if you dont need to.
            if (animalShelter.Peek().ShowType() == animal || animalShelter.Size == 1)
            {
                adoptedAnimal = animalShelter.Dequeue();
                foundAnimal = true;
            }
            // Filters through animalShelter and looks for animal if it isnt found it will add non matching animal to helperShelter and will keep checking.
            else
            {
                while (animalShelter.Peek().ShowType() != animal)
                {
                    helperShelter.Enqueue(animalShelter.Dequeue());
                }
                // Captures animal if found and makes it adoptedAnimal
                if (animalShelter.Size > 0)
                {
                    adoptedAnimal = animalShelter.Dequeue();
                    foundAnimal = true;
                }    
                // Adds rest of animals to helperShelter
                while (animalShelter.Size > 0)
                {
                    helperShelter.Enqueue(animalShelter.Dequeue());
                }
                // Returns animals to animalShelter in their original order.
                while (helperShelter.Size > 0)
                {
                    animalShelter.Enqueue(helperShelter.Dequeue());
                } 
            }
            // If target animal isnt found adopts oldest animal in shelter.
            if (foundAnimal == false)
            {
                adoptedAnimal = animalShelter.Dequeue();
            }
            return adoptedAnimal;
        }
    }
}
