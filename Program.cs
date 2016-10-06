using System;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal catInstance = new Cat("Rosalita", 10)
            {
                declawed = true
            };
            Animal foxInstance = new Fox("The Knoxiest Foxiest", 20)
            {
                foxColor = "red"
            };
            Animal goatInstance = new Goat("Gilbert The Super Goat", 15)
            {
                numberOfHorns = 2
            };
            Console.WriteLine($"Your new cat, {catInstance.name}, is {catInstance.weightInLbs}LBs.");
            catInstance.eat();
            Console.WriteLine($"Your new fox, {foxInstance.name}, is {foxInstance.weightInLbs}LBs");
            foxInstance.eat();
            Console.WriteLine($"Your new goat, {goatInstance.name}, is {goatInstance.weightInLbs}LBs");
            goatInstance.eat();
        }
    }
}
