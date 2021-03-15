using System.Collections.Generic;

namespace GaryGarage
{
    public interface IGasVehicles
    {
        List<string> electricVehicles { get; }
        void Learn();
    }
}