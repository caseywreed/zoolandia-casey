using System;

namespace Zoolandia.Animals
{
    public class MountainGoat : Species
    {
        public MountainGoat()
        {
        this.url = "https://en.wikipedia.org/wiki/Mountain_goat";
        this.genus = new Goat();
        this.scientificName = "Capra aegagrus hircus";
        this.commonName = "Mountain Goat";
        }
    }
}