using System;
using System.Collections.Generic;
using Zoolandia.Animals;
using Zoolandia.Habitats;
using Zoolandia.Buildings;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            // Construct a new zoo named Zoolandia
            Zoo zoolandia = new Zoo();

            // Construct the habitats for Zoolandia
            Forest greenForest = new Forest();
            greenForest.name = "Green Forest";

            Savanna savannaPlains = new Savanna();
            savannaPlains.name = "Dry Savanna";

            // Add those habitats to the Zoolandia zoo
            zoolandia.habitats.Add(savannaPlains);
            zoolandia.habitats.Add(greenForest);

            // Construct new instances of some animals
            SingleArcticFox artie = new SingleArcticFox();
            artie.name = "Artie";
            artie.weightInLbs = 35;
            artie.species = new ArcticFox();

            SingleOcelotCat ossie = new SingleOcelotCat();
            ossie.name = "Ossie";
            ossie.weightInLbs = 200;
            ossie.species = new OcelotCat();

            // Add those animals to their habitats
            savannaPlains.inhabitants.Add(ossie);
            greenForest.inhabitants.Add(artie);

            foreach (Habitat habitat in zoolandia.habitats)
            {
                Console.WriteLine($"{habitat.name}");
                foreach (Animal animal in habitat.inhabitants)
                {
                    Console.WriteLine($"{animal.name}");
                }
            }

        }
    }
}
