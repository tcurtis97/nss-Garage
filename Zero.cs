using System;

namespace GaryGarage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public double CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Zero zips by you, zzzzooooooooooommmmmm!");
        }
    }
}