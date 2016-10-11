using System;

namespace Zoolandia
{
    public class OcelotCat : Species
    {
        public OcelotCat()
        {
        this.url = "https://en.wikipedia.org/wiki/Ocelot";
        this.genus = new Cat();
        this.scientificName = "Leopardus pardalis";
        this.commonName = "Ocelot";
        }
    }
}