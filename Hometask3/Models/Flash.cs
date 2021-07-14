using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    // Крім того, кожен з похідних класів доповнюється такими полями:
    // - Клас Flash-пам'ять: обсяг пам'яті, швидкість USB;
    public class Flash : InfoCarrier
    {
        private uint memoryVolume;
        private uint uSBSpeed;

        public uint MemoryVolume { get => memoryVolume; set => memoryVolume = value; }
        public uint USBSpeed { get => uSBSpeed; set => uSBSpeed = value; }
    }
}
