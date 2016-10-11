using System;
using System.Collections.Generic;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            SingleArcticFox artie = new SingleArcticFox();
            artie.name = "Artie";
            artie.weightInLbs = 35;
            artie.species = new ArcticFox();
            Console.WriteLine(artie.walk());

            SingleOcelotCat ossie = new SingleOcelotCat();
            ossie.name = "Ossie";
            ossie.weightInLbs = 200;
            ossie.species = new OcelotCat();
            Console.WriteLine(ossie.swim());

            List<Animal> pets = new List<Animal>();
            pets.Add(artie);
            pets.Add(ossie);

            foreach (Animal animal in pets)
            {
                Console.WriteLine($"{animal.name}");
            }
            
        }
    }
}
