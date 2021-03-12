using System;

namespace GaryGarage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Zero zips by you, zzzzooooooooooommmmmm!");
        }
    }
}