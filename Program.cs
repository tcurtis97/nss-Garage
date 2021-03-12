using System;

namespace GaryGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero sr = new Zero()
            {
                MainColor = "blue",
                MaximumOccupancy = "two",
                BatteryKWh = 14.4
            };
            Ram longhorn = new Ram()
            {
                MainColor = "black",
                MaximumOccupancy = "four",
                FuelCapacity = 26
            };
            Tesla model3 = new Tesla()
            {
                MainColor = "white",
                MaximumOccupancy = "four",
                BatteryKWh = 75
            };
            Cessna cutlass = new Cessna()
            {
                MainColor = "red",
                MaximumOccupancy = "three",
                FuelCapacity = 62
            };

            sr.Drive();
            sr.Turn();
            sr.Stop();
            longhorn.Drive();
            longhorn.Turn();
            longhorn.Stop();
            model3.Drive();
            model3.Turn();
            model3.Stop();
            cutlass.Drive();
            cutlass.Turn();
            cutlass.Stop();



        }
    }
}
