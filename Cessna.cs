using System;

namespace GaryGarage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Cessna flies by you, Zoooooom!");
        }

        public override void Turn()
        {
            Console.WriteLine($"The cessna glides to the right");
        }

        public override void Stop()
        {
            Console.WriteLine($"The cessna comes to a stop after rolling down the strip");
        }
    }
}