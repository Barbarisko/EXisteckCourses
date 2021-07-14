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
        private uint passengers;
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

        public uint Passengers => passengers;

        public Ship()
        {

        }
        public Ship(uint _velocity, uint _prodyear, uint _passCapac, string _port)
        {
            Velocity = _velocity;
            ProdYear = _prodyear;
            PassengerCapacity = _passCapac;
            Cost = _velocity * _prodyear + _passCapac;
            Port = _port;
        }

        public void AddPeople(string quantity)
        {
            if (!quantity.All(char.IsDigit))
            {
                throw new ArgumentNullException("This is not a digit");
            }
            if ((passengers + Convert.ToUInt32(quantity)) > PassengerCapacity)
            {
                throw new Exception("Vi ne poplivete. Vi zhirnyi.");
            }

            passengers += Convert.ToUInt32(quantity);
        }

        public void KickPeople(string quantity)
        {
            if (!quantity.All(char.IsDigit))
            {
                throw new ArgumentNullException("This is not a digit");
            }
            if ((Convert.ToInt64(passengers) - Convert.ToInt64(quantity)) < 0)
            {
                throw new Exception("A zachem vam plavat'?");
            }

            passengers -= Convert.ToUInt32(quantity);
        }


        public override string ToString()
        {
            return $"Plavadlo {prodYear} roku vipusku, {velocity} km/god, vartue {cost} grn.\n" +
                $"Sidit v portu {port} , mae {passengers} passagiriv z {passengerCapacity}\n";
        }
    }
}
