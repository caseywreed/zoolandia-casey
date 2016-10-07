using System;

namespace Zoolandia
{
    public class Fox
    {
        public Fox ()
        {
            this.name = "The Knox Fox";
        }
        public Fox (string name)
        {
            this.name = name;
        }
        public Fox (int weight)
        {
            this.weightInLbs = weight;
        }
        public Fox (string name, int weight)
        {
            this.name = name;
            this.weightInLbs = weight;
        }
        public string foxColor {get; set;}

        public virtual void burrow()
        {
            Console.WriteLine($"The fox burrowed into its den");
        }
        public override void eat()
        {
            Console.WriteLine("The fox is trying to eat its prey.");
            base.eat();
        }
    }

}