namespace Zoolandia.Habitats
{
  public class Forest : Habitat
  {
    public string currentLocation { get; set; }

    public string destination { get; set; }

    public void move(string destination)
    {
      this.destination = destination;
    }
    public Forest(string location)
    {
      this.currentLocation = location;
    }
    public Forest()
    {
    }
  }
}
