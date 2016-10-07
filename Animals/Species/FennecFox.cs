using System;

namespace Zoolandia
{
    public class FennecFox : Species
    {
        public FennecFox ()
        {
            this.genus = new Fox();
        }
        public override string getSpeciesName()
        {
            return "Fennec Fox";
        }
        public override string speak()
        {
            return "Fox noise! Check out my ears!";
        }

    }

}