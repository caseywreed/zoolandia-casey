using System;

namespace Zoolandia
{
    public class OcelotCat : Species
    {
        public OcelotCat ()
        {
            this.genus = new Cat();
        }
        public override string getSpeciesName()
        {
            return "Ocelot";
        }
        public override string speak()
        {
            return "Ocelot noise! Rawr! Purr!";
        }

    }

}