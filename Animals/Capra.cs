using System;

namespace Zoolandia
{
    public class CapraAegagrusHircus : Animal
    {
        public CapraAegagrusHircus ()
        {
            this.name = "Gilbert";
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