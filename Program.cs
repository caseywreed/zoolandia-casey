using System;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal animalInstance = new Animal();
            Fox foxInstance = new Fox();
            ArcticFox arcticFoxInstance = new ArcticFox();
            // assign the genus and species to the ANIMAL instance
            animalInstance.species = arcticFoxInstance;
            animalInstance.genus = foxInstance;
            // Start assigning the more general animalInstance properties
            animalInstance.name = "Carl";
            animalInstance.weightInLbs = 15;
            
            Console.WriteLine($"Your new fox, {animalInstance.name}, is {animalInstance.weightInLbs}LBs and has this sound: {animalInstance.species.speak()}");
            // foxInstance.eat();
            // Console.WriteLine($"Your new cat, {catInstance.name}, is {catInstance.weightInLbs}LBs.");
            // catInstance.eat();
            // Console.WriteLine($"Your new goat, {goatInstance.name}, is {goatInstance.weightInLbs}LBs");
            // goatInstance.eat();
        }
    }
}
