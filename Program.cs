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

            Animal animal2 = new Animal();
            animal2.species = new FennecFox();
            animal2.name = "Paul";
            animal2.weightInLbs = 8;

            Animal animal3 = new Animal();
            animal3.species = new DomesticCat();
            animal3.name = "Rosalita";
            animal3.weightInLbs = 10;

            List<Animal> pets = new List<Animal>();
            pets.Add(animal1);
            pets.Add(animal2);
            pets.Add(animal3);

            foreach (Animal animal in pets)
            {
            Console.WriteLine($"Your new {animal.species.getSpeciesName()}, {animal.name}, is {animal.weightInLbs}LBs, a member of the {animal.species.genus.getGenus()} and has this sound: {animal.species.speak()}");
            }
            
        }
    }
}
