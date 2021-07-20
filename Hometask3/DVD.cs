using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    // - Клас DVD - диск: швидкість читання і швидкість запису.
    public class DVD : InfoCarrier
    {
        private uint readSpeed;
        private uint writeSpeed;

        public uint ReadSpeed { get => readSpeed; set => readSpeed = value; }
        public uint WriteSpeed { get => writeSpeed; set => writeSpeed = value; }

        public DVD(uint _readspeed, uint _writespeed):base()
        {
            readSpeed = _readspeed;
            writeSpeed = _writespeed;
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
    }
}
