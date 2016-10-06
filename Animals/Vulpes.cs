using System;

namespace Zoolandia
{
    public class VulpesVulpes : Animal
    {
        public VulpesVulpes ()
        {
            this.name = "The Knox Fox";
        }
        public string foxColor {get; set;}

        public static void burrow()
        {
            Console.WriteLine($"The fox burrowed into its den");
        }
        public override void eat()
        {
            Console.WriteLine("The fox is trying to eat its prey.\n{base.eat()}");
        }
    }

}