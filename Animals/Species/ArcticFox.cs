using System;

namespace Zoolandia
{
    public class ArcticFox : Species
    {
        public ArcticFox ()
        {
            this.genus = new Fox();
        }
        public override string getSpeciesName()
        {
            return "Arctic Fox";
        }
        public override string speak()
        {
            return "Meow? But also brr";
        }
    }

}