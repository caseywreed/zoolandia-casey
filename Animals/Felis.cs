using System;

namespace Zoolandia
{
    public class FelisCatus : Animal
    {
        public FelisCatus ()
        {
            this.name = "Rosalita";
        }
        public bool declawed {get; set;}
        public static void knockShitOffCounter()
        {
            Console.WriteLine($"The cat took your favorite shotglass and knocked it off the counter");
        }
        public override void eat()
        {
            Console.WriteLine("The cat is trying to eat its Fancy Feast.\n{base.eat()}");
        }
    }

}