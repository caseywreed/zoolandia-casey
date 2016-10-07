using System;
using System.Collections.Generic;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal animalInstance = new Animal();
            Fox genus = new Fox();
            ArcticFox species = new ArcticFox();
            // assign the genus and species to the ANIMAL instance
            animalInstance.genus = genus;
            animalInstance.species = species;
            // Start assigning the more general animalInstance properties
            animalInstance.name = "Carl";
            animalInstance.weightInLbs = 15;

            Animal animal2 = new Animal();
            Fox genus2 = new Fox();
            FennecFox species2 = new FennecFox();
            // assign the genus and species to the ANIMAL instance
            animal2.genus = genus2;
            animal2.species = species2;
            // Start assigning the more general animal2 properties
            animal2.name = "Paul";
            animal2.weightInLbs = 8;

            Animal animal3 = new Animal();
            Cat genus3 = new Cat();
            DomesticCat species3 = new DomesticCat();
            // assign the genus and species to the ANIMAL instance
            animal3.genus = genus3;
            animal3.species = species3;
            // Start assigning the more general animal3 properties
            animal3.name = "Rosalita";
            animal3.weightInLbs = 10;

            List<Animal> pets = new List<Animal>();
            pets.Add(animalInstance);
            pets.Add(animal2);
            pets.Add(animal3);

            foreach (Animal animal in pets)
            {
            Console.WriteLine($"Your new {animal.species.getSpeciesName()}, {animal.name}, is {animal.weightInLbs}LBs, a member of the {animal.genus.getGenus()} and has this sound: {animal.species.speak()}");
            }
            
        }
    }
}
