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
        private uint passengers = 0;
        private int flightHeight;

        public uint Cost { get => cost; set => cost = value; }
        public uint Velocity { get => velocity; set => velocity = value; }
        public uint ProdYear { get => prodYear; set => prodYear = value; }
        public uint PassengerCapacity { get => passengerCapacity; set => passengerCapacity = value; }
        public int FlightHeight { get => flightHeight; set => flightHeight = value; }

        public uint Passengers { get => passengers; }

        public PLane()
        {
            Velocity = 100;
            ProdYear = 1990;
            PassengerCapacity = 50;
            Cost = velocity * prodYear * passengerCapacity;
            FlightHeight = 0;
        }
        public PLane(uint _velocity, uint _prodyear, uint _passCapac)
        {
            Velocity = _velocity;
            ProdYear = _prodyear;
            PassengerCapacity = _passCapac;
            Cost = _velocity * _prodyear * _passCapac;
            FlightHeight = 0;
        }

        public int Ascend(string height)
        {
            if (!height.All(char.IsDigit))
            {
                throw new ArgumentNullException("This is not a digit");
            }            

            FlightHeight += Convert.ToInt32(height);

            return FlightHeight;
        }
        public int Descend(string height)
        {
            if (!height.All(char.IsDigit))
            {
                throw new ArgumentNullException("This is not a digit");
            }            
            if((FlightHeight - Convert.ToInt32(height)) < 0)
            {
                throw new Exception("Vi pod zeml'ey");
            }

            FlightHeight -= Convert.ToInt32(height);

            return FlightHeight;
        }

        public void AddPeople(string quantity)
        {
            if (!quantity.All(char.IsDigit))
            {
                throw new ArgumentNullException("This is not a digit");
            }
            if ((passengers + Convert.ToUInt32(quantity)) > PassengerCapacity)
            {
                throw new Exception("Vi ne poletite. Vi zhirnyi.");
            }

            passengers += Convert.ToUInt32(quantity);
        }
        public void KickPeople(string quantity)
        {
            if (!quantity.All(char.IsDigit))
            {
                throw new ArgumentNullException("This is not a digit");
            }
            if ((passengers - Convert.ToUInt32(quantity)) <0)
            {
                throw new Exception("A zachem vam letet'?");
            }

            passengers -= Convert.ToUInt32(quantity);
        }


        public override string ToString()
        {
            return $"Letadlo {prodYear} roku vipusku, {velocity} km/god, vartue {cost} grn.\n" +
                $"Litae na visoti {flightHeight} m, mae {passengers} passagiriv z {passengerCapacity}";
        }
    }
}
