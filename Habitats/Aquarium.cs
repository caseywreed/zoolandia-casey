using System;

namespace Zoolandia.Habitats
{
  public class Aquarium : Habitat, IAquatic
  {
    public bool isFreshwater {get;set;}
    public double waterTemperature {get;set;}
    public string filterType {get;set;}
    public string pumpType {get;set;}
    public Aquarium()
    {
        
    }
  }
}
