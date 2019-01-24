using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Classes
{
    /// <summary>
    /// restricts animal type to cat or dog.
    /// </summary>
    public enum AnimalType
    {
        cat,
        dog
    }

    /// <summary>
    /// base class if animal acts as a node for the queue.
    /// </summary>
    public abstract class Animal
    {
        
        public abstract AnimalType Type { get; set; }
        public abstract string Name { get; set; }
        public Animal Next { get; set; }

        /// <summary>
        /// When called shows the type of animal.
        /// </summary>
        /// <returns>AnimalType enum</returns>
        public virtual AnimalType ShowType()
        {
            return Type;
        }
    }
}
