using System.Collections.Generic;
using Zoolandia.Animals;

namespace Zoolandia.Habitats
{
  public class Habitat
  {
    public int width;
    public int depth;
    public int height;
    public string name;

    public List<Animal> inhabitants = new List<Animal>();

  }
}
