using System;

namespace GaryGarage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Tesla whips by you, mmmmmmmmmmmmmmmm!");
        }
    }
}