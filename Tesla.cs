using System;

namespace GaryGarage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Tesla whips by you, mmmmmmmmmmmmmmmm!");
        }
    }
}