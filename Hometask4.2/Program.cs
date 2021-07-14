using System;

namespace Hometask4._2
{
    //Створити делегат, для методів класу Circle і продемонструвати роботу делегата

    delegate void CircleFeatures(double radius);

    class Program
    {
        private static void PrintRadius(double radius)
        {
            Console.WriteLine($"GetRadius(): {radius}");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hi! You're about to create a circle! \n Please input parameter radius:");
            try
            {
                CircleFeatures RadDlg, DiamDlg, LengthDlg, AreaDlg;
                var radius = Convert.ToDouble(Console.ReadLine());
                Circle circle = new Circle(radius);

                RadDlg = PrintRadius;
                Console.WriteLine("Invoking delegate RadDlg:");
                RadDlg(circle.Radius);

                DiamDlg = PrintDiameter;
                Console.WriteLine("Invoking delegate DiamDlg:");
                DiamDlg(circle.GetDiameter());

                LengthDlg = PrintLength;
                Console.WriteLine("Invoking delegate LengthDlg:");
                LengthDlg(circle.GetCircleLength());

                AreaDlg = PrintArea;
                Console.WriteLine("Invoking delegate AreaDlg:");
                AreaDlg(circle.GetCircleArea());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Clear();
                Console.ReadKey();
            }
        }

       
        private static void PrintDiameter(double radius)
        {
            Console.WriteLine($"GetDiameter(): {radius}");
        }
        private static void PrintLength(double radius)
        {
            Console.WriteLine($"GetLength(): {radius}");
        }
        private static void PrintArea(double radius)
        {
            Console.WriteLine($"GetArea(): {radius}");
        }
    }
}
