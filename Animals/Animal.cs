using System;

namespace Zoolandia
{
    public class Animal
    {
        public string name {get; set;}
        public int weightInLbs {get; set;}
        public static void sleep()
        {
            Console.WriteLine("Animal is asleep!");
        }
    }

}