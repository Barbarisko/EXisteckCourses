using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    // Крім того, кожен з похідних класів доповнюється такими полями:
    // - Клас DVD - диск: швидкість читання і швидкість запису.
    public class DVD : InfoCarrier
    {
        private uint readSpeed;
        private uint writeSpeed;

        public uint ReadSpeed { get => readSpeed; set => readSpeed = value; }
        public uint WriteSpeed { get => writeSpeed; set => writeSpeed = value; }
    }
}
