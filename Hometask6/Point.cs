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
//При створені першого екземпляра класу Point, властивості Name автоматично надавалося значення у вигляді символу починаючи з символу «А». При створенні наступного екземпляру властивість Name має містити значення «B». При створенні наступних екземплярів властивість Name містить значення в алфавітному порядку(C, D, і так далі).
//Кількість створених екземплярів не має перевищувати 26 
//Для виконання завдання використовувати статичні поля, статичні методи

    public class Point
    {
        public int CoordX { get; set; } 
        public int CoordY { get; set; } 
        public char Name { get; set; } 
    }
}
