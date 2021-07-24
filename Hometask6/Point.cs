using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask6
{
    //    Створити клас Point що містить наступні властивості:
    //·        Координата X
    //·        Координата Y
    //·        Char Name
    //При створені першого екземпляра класу Point, властивості Name автоматично надавалося значення у вигляді символу починаючи з символу «А».
    //При створенні наступного екземпляру властивість Name має містити значення «B».
    //При створенні наступних екземплярів властивість Name містить значення в алфавітному порядку(C, D, і так далі).
    //Кількість створених екземплярів не має перевищувати 26 
    //Для виконання завдання використовувати статичні поля, статичні методи

    public class Point
    {
        private char name;
        private static char lastName = 'A';
        private int coordY;
        private int coordX;

        public int CoordX { get => coordX; set => coordX = value; }
        public int CoordY { get => coordY; set => coordY = value; }
        public char Name { get => name; set => name = value; }

        public Point(int _x, int _y)
        {
            coordX = _x;
            coordY = _y;
            SetName(name);
        }
        private static void SetName(char name)
        {
            if (lastName + 1 > 'A' + 26) { lastName = 'A'; }
            name = Convert.ToChar(lastName++);
            Console.WriteLine("New point " + name + " created");
        }
    }
}
