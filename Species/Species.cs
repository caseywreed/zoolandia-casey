using System;

namespace Zoolandia
{
    public class Species
    {
        public Genus genus {get; set;}
        public virtual string getSpeciesName()
        {
            return "Default species";
        }
        public virtual string speak()
        {
            return "Default noise";
        } 
    }

}