using System;

namespace Zoolandia
{
    public class Goat : Genus
    {
    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Goat";
      this.trait = "Death metal vocals";
      this.commonName = "Goat";
      this.scientificName = "Capra";
    }

    public Goat()
    {
      this.init();
    }
    }

}