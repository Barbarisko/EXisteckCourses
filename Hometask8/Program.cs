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
            while (true)
            {
                try
                {
                    Console.WriteLine("Creating first matrix to multiply." +
                " \n Input rows(A) and columns(B) like: \n A \n B");
                    var A = Convert.ToUInt32(Console.ReadLine());
                    var B = Convert.ToUInt32(Console.ReadLine());

                    A = A < 10 ? 10 : A;
                    B = B < 10 ? 10 : B;

                    var matrix1 = new Matrix(A, B);
                    matrix1.PrintMatrix(matrix1);

                    Console.WriteLine("Creating second matrix to multiply." +
                    " \n Input rows(C) and columns(D) like: \n C \n D");
                    var C = Convert.ToUInt32(Console.ReadLine());
                    var D = Convert.ToUInt32(Console.ReadLine());

                    C = C < 10 ? 10 : C;
                    D = D < 10 ? 10 : D;

                    var matrix2 = new Matrix(C, D);
                    matrix2.PrintMatrix(matrix2);

                    var resulting = matrix1 * matrix2;
                    resulting.PrintMatrix(resulting);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
