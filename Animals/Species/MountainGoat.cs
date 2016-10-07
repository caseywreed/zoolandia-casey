using System;

namespace Zoolandia
{
    public class MountainGoat : Species
    {
        public MountainGoat ()
        {
            this.genus = new Goat();
        }
        public override string getSpeciesName()
        {
            return "Mountain Goat";
        }
        public override string speak()
        {
            return "***YODELS LOUDLY***";
        }

    }

}