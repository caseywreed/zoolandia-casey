using System;

namespace Zoolandia
{
    public class ArcticFox : Species
    {
        public ArcticFox()
        {
        this.url = "https://en.wikipedia.org/wiki/Arctic_fox";
        this.genus = new Fox();
        this.scientificName = "Vulpes lagopus";
        this.commonName = "Arctic Fox";
        }
    }
}