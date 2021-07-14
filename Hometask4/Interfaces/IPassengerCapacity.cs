using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask4.Interfaces
{
    //Для літака повинна бути визначена висота, для літака і судна – кількість пасажирів, для судна – порт приписки.
    public interface IPassengerCapacity
    {
        uint PassengerCapacity { get; set; }
        uint Passengers { get; }

        void AddPeople(string quantity);
        void KickPeople(string quantity);
    }
}
