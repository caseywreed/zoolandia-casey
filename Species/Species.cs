using System;

namespace Zoolandia
{
    public class Species
    {
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