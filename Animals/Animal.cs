using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name {get; set;}
        public int weightInLbs {get; set;}
        public Species species {get; set;}
        public virtual string sleep()
        {
           return "The animal is asleep!";
        }
        public virtual string eat()
        {
            return "The animal ate successfully";
        }
        public virtual string speak()
        {
            return "Default noise";
        } 
    }

}