using System;
using System.Collections.Generic;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            animal1.species = new ArcticFox();
            animal1.name = "Carl";
            animal1.weightInLbs = 15;

            List<Animal> pets = new List<Animal>();
            pets.Add(animal1);

            foreach (Animal animal in pets)
            {
            Console.WriteLine($"Your new {animal.species.getSpeciesName()}, {animal.name}, is {animal.weightInLbs}LBs, a member of the {animal.species.genus.getGenus()} and has this sound: {animal.species.speak()}");
            }
            
        }
    }
}
