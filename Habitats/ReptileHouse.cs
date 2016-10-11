using System;

namespace Zoolandia.Habitats
{
  public class ReptileHouse : Habitat, IHeated
  {
    public ReptileHouse()
    {

    }
    public string heatLampType {get;set;}
    public double heatTemperature {get;set;}
    public double numberOfLamps {get;set;}
    }
}
