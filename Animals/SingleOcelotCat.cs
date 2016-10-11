using System;

namespace Zoolandia.Animals
{
    public class SingleOcelotCat : Animal, IWalking, ISwimming
    {
        public void init () 
        {
            this.walkSpeed = 50;
            this.swimSpeed = 3;
        }
        public SingleOcelotCat ()
        {
            this.init();
        }
        public int walkSpeed {get;set;}
        public int swimSpeed {get;set;}
        public string walk()
        {
            return $"The ocelot walked at {this.walkSpeed}MPH";
        }

        public string swim()
        {
            return $"The ocelot swam at at {this.swimSpeed}MPH";
        }
    }
}
