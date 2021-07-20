using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    // - Клас знімний HDD: розмір диска, швидкість USB;
    public class HDD : InfoCarrier
    {
        private uint diskCapacity;
        private uint uSBSpeed;

        public uint DiskCapacity { get => diskCapacity; set => diskCapacity = value; }
        public uint USBSpeed { get => uSBSpeed; set => uSBSpeed = value; }

        public HDD(uint _diskCapacity, uint _usbSpeed):base()
        {
            diskCapacity = _diskCapacity;
            uSBSpeed = _usbSpeed;
        }

        public override void DownloadInto(string info) 
        {
            Console.WriteLine("Downloaded from HDD.");
        }
        public override void Save(string info)
        {
            this.Information += $"{info}\n";
            Console.WriteLine("Saved to HDD.");
        }

        public static string operator -(HDD disk, string old_info)
        {
            if (disk.Information.Contains(old_info))
            {
                return disk.Information.Trim(Convert.ToChar(old_info));
            }
            return "deleted?";
        }
        public static string operator +(HDD disk, string new_info)
        {
            return $"{disk.Information} \n {new_info}";
        }
    }
}
