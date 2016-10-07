using System;

namespace Zoolandia
{
    public class FennecFox : Fox
    {
        public bool hasPointyEars {get;set;}
        public override void burrow()
        {
            Console.WriteLine($"The fox burrowed into its bundle of towels");
        }

    }

}