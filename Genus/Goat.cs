using System;

namespace Zoolandia
{
    public class Goat : Animal
    {
        public Goat ()
        {
            this.name = "Gilbert";
        }
        public Goat (string name)
        {
            this.name = name;
        }
        public Goat (int weight)
        {
            this.weightInLbs = weight;
        }
        public Goat (string name, int weight)
        {
            this.name = name;
            this.weightInLbs = weight;
        }
        public int numberOfHorns {get; set;}
        public bool hasGoatAgility {get; set;}

        public static void goatHop()
        {
            Console.WriteLine($"The goat hopped!");
        }
        public override void eat()
        {
            Console.WriteLine("The goat is trying to eat a can.");
            base.eat();
        }
    }

}