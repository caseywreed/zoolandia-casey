using System;

namespace Zoolandia
{
    public class BritishAlpineGoat : Species
    {
        public BritishAlpineGoat ()
        {
            this.genus = new Goat();
        }
        public override string getSpeciesName()
        {
            return "British Alpine Goat";
        }
        public override string speak()
        {
            return "Pip-pip, cheerio!";
        }

    }

}