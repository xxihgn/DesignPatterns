using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    internal class AnimalWorld<T> : IAnimalWorld where T : IContinentFactory, new()
    {
        private readonly IHerbivore herbivore;
        private readonly ICarnivore carnivore;

        public AnimalWorld()
        {
            // Create new continent factory
            var factory = new T();

            // Factory creates carnivores and herbivores
            carnivore = factory.CreateCarnivore();
            herbivore = factory.CreateHerbivore();
        }

        /// <summary>
        /// Runs the foodchain: carnivores are eating herbivores.
        /// </summary>
        public void RunFoodChain()
        {
            carnivore.Eat(herbivore);
        }
    }
}
