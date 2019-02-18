using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Classes
{
    public class Dog : Animal
    {
        public override AnimalType Type { get; set; } = AnimalType.dog;
        public override string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }
    }
}
