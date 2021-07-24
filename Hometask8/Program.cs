using System;

namespace Hometask8
{
    //Розробити додаток для багато поточного множення матриць.
    //Мінімальний розмір матриці 10x10.
    //Кожна ітерація перемноження має виконуватися в окремому потоці.
    //Далі результат кожної ітерації просумувати і вивести остаточний результат.
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Matrix(2, 3) * new Matrix(3, 2);
            a.PrintMatrix(a);

            Console.WriteLine("Hello World!");
        }
    }
}
