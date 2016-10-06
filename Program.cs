using System;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal catInstance = new FelisCatus()
            {
                name = "Rosalita",
                weightInLbs = 12,
                declawed = true
            };
            Animal foxInstance = new VulpesVulpes()
            {
                name = "The Knox Fox",
                weightInLbs = 25,
                foxColor = "red"
            };
            Animal goatInstance = new CapraAegagrusHircus()
            {
                name = "Gilbert",
                weightInLbs = 25,
                numberOfHorns = 2
            };
            Console.WriteLine($"Your new cat, {catInstance.name}, is {catInstance.weightInLbs}LBs");
            Console.WriteLine($"Your new fox, {foxInstance.name}, is {foxInstance.weightInLbs}LBs");
            Console.WriteLine($"Your new goat, {goatInstance.name}, is {goatInstance.weightInLbs}LBs");
        }
    }
}
