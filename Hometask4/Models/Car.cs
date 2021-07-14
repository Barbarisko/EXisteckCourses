using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask4
{
    public class Car : IVehicle
    {
        private uint cost;
        private uint velocity;
        private uint prodYear;

        public uint Cost { get => cost; set => cost = value; }
        public uint Velocity { get => velocity; set => velocity = value; }
        public uint ProdYear { get => prodYear; set => prodYear = value; }
    }
}
