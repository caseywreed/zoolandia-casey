using System;

namespace Zoolandia
{
    public class DomesticCat : Species
    {
        public override string getSpeciesName()
        {
            return "Domestic Shorthair Cat";
        }
        public override string speak()
        {
            return "I'm a bitch! I knock over all your cassette tapes!";
        }

    }

}