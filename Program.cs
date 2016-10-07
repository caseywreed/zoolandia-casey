using System;

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
            
            Console.WriteLine($"Your new {animalInstance.species.getSpeciesName()}, {animalInstance.name}, is {animalInstance.weightInLbs}LBs, is a member of the {animalInstance.genus.getGenus()} and has this sound: {animalInstance.species.speak()}");
        }
    }
}
