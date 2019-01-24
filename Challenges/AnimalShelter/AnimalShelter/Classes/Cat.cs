using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Classes
{
    public class Cat : Animal
    {
        public override AnimalType Type { get; set; } = AnimalType.cat;
        public override string Name { get; set; }

        public Cat(string name)
        {
            Name = name;
        }

        
    }
}
