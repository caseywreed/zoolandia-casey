using System;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal catInstance = new FelisCatus()
            {
                weightInLbs = 12,
                declawed = true
            };
            Animal foxInstance = new VulpesVulpes()
            {
                weightInLbs = 25,
                foxColor = "red"
            };
            Animal goatInstance = new CapraAegagrusHircus()
            {
                weightInLbs = 25,
                numberOfHorns = 2
            };
            Console.WriteLine($"Your new cat, {catInstance.name}, is {catInstance.weightInLbs}LBs.");
            // Console.WriteLine(catInstance.eat())
            Console.WriteLine($"Your new fox, {foxInstance.name}, is {foxInstance.weightInLbs}LBs");
            Console.WriteLine($"Your new goat, {goatInstance.name}, is {goatInstance.weightInLbs}LBs");
        }
    }
}
