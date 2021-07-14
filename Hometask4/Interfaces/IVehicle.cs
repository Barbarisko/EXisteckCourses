using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask4
{
    //Розробити інтерфейс IVehicle(транспортний засіб).
    //Класи повинні мати можливість задавати і отримувати координати і параметри засобів пересування
    //(вартість, швидкість, рік випуску і т.д.) за допомогою властивостей і оголосити їх в інтерфейсі.

    public interface IVehicle
    {
        uint Cost { get; set; }
        uint Velocity { get; set; }
        uint ProdYear { get; set; }
    }
}
