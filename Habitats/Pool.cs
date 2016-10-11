using System;

namespace Zoolandia.Habitats
{
  public class Pool : Habitat, IAquatic
  {
    public Pool()
    {

    }
    public string filterType {get;set;}
    public bool isFreshwater {get;set;}
    public string pumpType {get;set;}
    public double waterTemperature {get;set;}

    }
}
