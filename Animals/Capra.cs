using System;

namespace Zoolandia
{
    public class CapraAegagrusHircus : Animal
    {
        public int numberOfHorns {get; set;}
        public bool hasGoatAgility {get; set;}

        public static void goatHop()
        {
            Console.WriteLine($"The goat hopped!");
        }
    }

}