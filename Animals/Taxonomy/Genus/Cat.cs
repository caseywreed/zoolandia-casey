using System;

namespace Zoolandia
{
    public class Cat : Genus
    {
    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Cat";
      this.trait = "Being a cuddlebug";
      this.commonName = "Cat";
      this.scientificName = "Felis";
    }

    public Cat()
    {
      this.init();
    }
    }

}