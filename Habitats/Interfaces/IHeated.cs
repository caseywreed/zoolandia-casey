namespace Zoolandia.Habitats
{
  public interface IHeated
  {
    double heatTemperature { get; set; }
    string heatLampType { get; set; }
    double numberOfLamps {get; set;}
  }
}
