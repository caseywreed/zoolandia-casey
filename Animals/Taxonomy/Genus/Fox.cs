using System;

namespace Zoolandia.Animals
{
    public class Fox : Genus
    {
    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Fox";
      this.trait = "Looking cute while playing in the snow";
      this.commonName = "Fox";
      this.scientificName = "Canidae";
    }

    public Fox()
    {
      this.init();
    }
    }

}