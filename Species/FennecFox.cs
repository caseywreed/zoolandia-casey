using System;

namespace Zoolandia
{
    public class FennecFox : Species
    {
        public override string getSpeciesName()
        {
            return "Fennec Fox";
        }
        public string speciesName {get;set;}
        
        public override string speak()
        {
            return "Fox noise! Check out my ears!";
        }

    }

}