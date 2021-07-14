using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    // Крім того, кожен з похідних класів доповнюється такими полями:
    // - Клас знімний HDD: розмір диска, швидкість USB;
    public class HDD : InfoCarrier
    {
        private uint uSBSpeed;
        private uint capacity;

        public uint Capacity { get => capacity; set => capacity = value; }
        public uint USBSpeed { get => uSBSpeed; set => uSBSpeed = value; }
    }
}
