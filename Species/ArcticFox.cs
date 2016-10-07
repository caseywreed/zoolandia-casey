using System;

namespace Zoolandia
{
    public class ArcticFox : Fox
    {
        public int supersonicHearingRating {get; set;}
        public override void burrow()
        {
            Console.WriteLine($"The fox burrowed into its snow bank");
        }

    }

}