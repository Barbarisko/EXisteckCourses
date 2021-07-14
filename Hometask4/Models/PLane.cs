using Hometask4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask4
{
    //Для літака повинна бути визначена висота, для літака і судна – кількість пасажирів

    public class PLane : IVehicle, IPassengerCapacity
    {
        private uint cost;
        private uint velocity;
        private uint prodYear;
        private uint passengerCapacity;
        private string flightHeight;

        public uint Cost { get => cost; set => cost = value; }
        public uint Velocity { get => velocity; set => velocity = value; }
        public uint ProdYear { get => prodYear; set => prodYear = value; }
        public uint PassengerCapacity { get => passengerCapacity; set => passengerCapacity = value; }
        public string FlightHeight { get => flightHeight; set => flightHeight = value; }
    }
}
