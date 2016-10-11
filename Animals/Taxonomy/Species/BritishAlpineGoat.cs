using System;

namespace Zoolandia.Animals
{
    public class BritishAlpineGoat : Species
    {
        public BritishAlpineGoat()
        {
        this.url = "https://en.wikipedia.org/wiki/British_Alpine_goat";
        this.genus = new Goat();
        this.scientificName = "Capra aegagrus hircus";
        this.commonName = "British Alpine Goat";
        }
    }
}