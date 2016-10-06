using System;

namespace Zoolandia
{
    public class Cat : Animal
    {
        public Cat ()
        {
            this.name = "Rosalita";
        }
        public Cat (string name)
        {
            this.name = name;
        }
        public Cat (int weight)
        {
            this.weightInLbs = weight;
        }
        public Cat (string name, int weight)
        {
            this.name = name;
            this.weightInLbs = weight;
        }
        public bool declawed {get; set;}
        public static void knockShitOffCounter()
        {
            Console.WriteLine($"The cat took your favorite shotglass and knocked it off the counter");
        }
        public override void eat()
        {
            Console.WriteLine("The cat is trying to eat its Fancy Feast.");
            base.eat();
        }
    }

}