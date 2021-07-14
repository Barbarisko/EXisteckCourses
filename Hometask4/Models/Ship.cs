using Hometask4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask4
{
    //Для судна повинен бути визначений порт приписки, для літака і судна – кількість пасажирів.
    public class Ship : IVehicle, IPassengerCapacity
    {
        private uint cost;
        private uint velocity;
        private uint prodYear;
        private uint passengerCapacity;
        private string port;

        public uint Cost { get => cost; set => cost = value; }
        public uint Velocity { get => velocity; set => velocity = value; }
        public uint ProdYear { get => prodYear; set => prodYear = value; }
        public uint PassengerCapacity { get => passengerCapacity; set => passengerCapacity = value; }
        public string Port { get => port; set => port = value; }
    }
}
