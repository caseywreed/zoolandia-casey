using System;

namespace Zoolandia
{
    public class DomesticCat : Species
    {
        public DomesticCat()
        {
        this.url = "https://en.wikipedia.org/wiki/Cat";
        this.genus = new Cat();
        this.scientificName = "Felis Catus";
        this.commonName = "Domestic Cat";
        }
    }
}