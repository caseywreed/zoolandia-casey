using System;

namespace Zoolandia
{
    public class Fox : Genus
    {
        public virtual void burrow()
        {
            Console.WriteLine($"The fox burrowed into its den");
        }
        public override string getGenus ()
        {
            return "Fox Genus";
        }
    }

}