using System;

namespace Zoolandia
{
    public class Animal
    {
        public string name {get; set;}
        public int weightInLbs {get; set;}
        public Species species {get; set;}
        public Genus genus {get; set;}
        public virtual void sleep()
        {
            Console.WriteLine("The animal is asleep!");
        }
        public virtual void eat()
        {
            Console.WriteLine("The animal ate successfully\n");
        }
    }

}