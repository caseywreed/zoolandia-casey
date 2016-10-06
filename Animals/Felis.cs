using System;

namespace Zoolandia
{
    public class FelisCatus : Animal
    {
        public bool declawed {get; set;}
        public static void knockShitOffCounter()
        {
            Console.WriteLine($"The cat took your favorite shotglass and knocked it off the counter");
        }
    }

}