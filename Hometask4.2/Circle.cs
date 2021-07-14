using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask4._2
{
    //Завдання 2 (Делегати)
    //Створити клас Circle, в якому описані чотири методи, які виводять на консоль радіус, діаметр, довжину окружності, площу кола.
    public class Circle
    {
        private double radius;

        public double Radius { get => radius; set => radius = value; }
        public readonly double Pi = 3.14;

        public Circle(double _radius)
        {
            Radius = _radius;
        }

        public double GetRadius()
        {
            return Radius;
        }
        public double GetDiameter()
        {
            return Radius*2;
        }
        public double GetCircleLength()
        {
            return Radius*2*Pi;
        }
        public double GetCircleArea()
        {
            return Math.Pow(Radius, 2)*Pi;
        }
    }
}
