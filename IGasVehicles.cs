using System.Collections.Generic;

namespace GaryGarage
{
    public interface IGasVehicles
    {
        double FuelCapacity { get; set; }
        double CurrentTankPercentage { get; set; }

        void RefuelTank();
    }
}