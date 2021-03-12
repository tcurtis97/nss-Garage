using System;

namespace GaryGarage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Ram rumbles by you, RRrrrrrummbbble!");
        }
    }
}