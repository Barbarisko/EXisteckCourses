using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    // - Клас Flash-пам'ять: обсяг пам'яті, швидкість USB;

    public class Flash : InfoCarrier
    {
        private uint memoryCapacity;
        private uint uSBSpeed;

        public uint MemoryCapacity { get => memoryCapacity; set => memoryCapacity = value; }
        public uint USBSpeed { get => uSBSpeed; set => uSBSpeed = value; }

        public Flash(uint _memCapacity, uint _usbSpeed)
        {
            memoryCapacity = _memCapacity;
            uSBSpeed = _usbSpeed;
        }
        public override void DownloadInto(string info)
        {
            Console.WriteLine("Downloaded from Flash.");
        }
        public override void Save(string info)
        {
            this.Information += $"{info}\n";
            Console.WriteLine("Saved to Flash.");
        }
    }
}
