using System.Collections.Generic;

namespace GaryGarage
{
    public interface IElectricVehicle
    {
        List<string> electricVehicles { get; }
        void ChargeBattery();
    }
}