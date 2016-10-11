using System;

namespace Zoolandia.Animals
{
    public class SingleArcticFox : Animal, IWalking
    {
        public void init () 
        {
            this.walkSpeed = 50;
        }
        public SingleArcticFox ()
        {
            this.init();
        }
        public int walkSpeed {get;set;}

        public string walk()
        {
            return $"The fox walked at {this.walkSpeed}MPH";
        }
    }
}
