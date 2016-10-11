namespace Zoolandia.Habitats
{
  public class Savanna : Habitat, IHeated
  {
    public Savanna()
    {
    }
    public string heatLampType {get;set;}
    public double heatTemperature {get;set;}
    public double numberOfLamps {get;set;}
  }
}
