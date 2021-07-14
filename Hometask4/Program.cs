using System;

namespace Hometask4
{

    //        Завдання 1 (Інтерфейси)
    //Розробити інтерфейс IVehicle(транспортний засіб).
    //На його основі реалізувати класи Plane(літак) Car(автомобіль)  Ship(судно).
    //Класи повинні мати можливість задавати і отримувати координати і параметри засобів пересування
    //(вартість, швидкість, рік випуску і т.д.) за допомогою властивостей і оголосити їх в інтерфейсі.
    //Для літака повинна бути визначена висота, для літака і судна – кількість пасажирів, для судна – порт приписки.
    //Динамічні характеристики задавати за допомогою методів.
    //Створити метод для роздруківки стану транспортного засобу (кількість пасажир, порт, аеропорт і т.д.)
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("You can :\n" +
                "1 - creaTe caR \n" +
                "2 - creAte planE \n" +
                "3 - CReatE shIp\n" +
                "4 - exit.\n");
                    string res = Console.ReadLine();

                    Swithc(Convert.ToInt32(res)-1);

                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }
            }
        }

        private static void Swithc(int res)
        {
            switch (res)
            {  
                case 0:
                    Console.WriteLine("You are to create a car. Input all parameters:");
                    uint velocity, prodYear = 0;
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Velocity:");
                            velocity = Convert.ToUInt32(Console.ReadLine());
                            Console.WriteLine("Production Year:");
                            prodYear = Convert.ToUInt16(Console.ReadLine());
                            break;
                        }
                        catch(Exception e)
                        {
                            CatchActions(e);
                        }
                    }
                    Car car = new Car(velocity, prodYear);
                    Console.WriteLine(car.ToString());
                    break;

                case 1:
                    Console.WriteLine("You are to create a plane. Input all parameters:");
                    uint passCapacity = 0;
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Velocity:");
                            velocity = Convert.ToUInt32(Console.ReadLine());
                            Console.WriteLine("Production Year:");
                            prodYear = Convert.ToUInt16(Console.ReadLine());
                            Console.WriteLine("Passanger Capacity:");
                            passCapacity = Convert.ToUInt16(Console.ReadLine());
                            break;
                        }
                        catch (Exception e)
                        {
                            CatchActions(e);
                        }
                    }
                    PLane plane = new PLane(velocity, prodYear, passCapacity);
                    Console.WriteLine(plane.ToString());

                    ModifyPlane(plane);
                    break;

                case 2:
                    Console.WriteLine("You are to create a ship. Input all parameters:");
                    string port = "";
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Velocity:");
                            velocity = Convert.ToUInt32(Console.ReadLine());
                            Console.WriteLine("Production Year:");
                            prodYear = Convert.ToUInt16(Console.ReadLine());
                            Console.WriteLine("Passanger Capacity:");
                            passCapacity = Convert.ToUInt16(Console.ReadLine());
                            Console.WriteLine("Port:");
                            port = Console.ReadLine();
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.Clear();
                            Console.WriteLine(e.Message);
                            Console.ReadKey();
                        }
                    }
                    Ship ship = new Ship(velocity, prodYear, passCapacity, port);
                    Console.WriteLine(ship.ToString());

                    ModifyShip(ship);
                    break;
                    
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No available choise");
                    break;
            }
        }

        private static void ModifyPlane(PLane pLane)
        {
          
            while (true)
            {
                Console.WriteLine("You can :\n" +
              "1 - info \n" +
              "2 - add passengers \n" +
              "3 - kick passengers\n" +
              "4 - get high\n" +
              "5 - lose hight \n" +
              "6 - exit.\n");
                try
                {
                    uint res = Convert.ToUInt32(Console.ReadLine())-1;

                    switch (res)
                    {
                        case 0:
                            Console.WriteLine(pLane.ToString());
                            break;
                        case 1:
                            Console.WriteLine("how many?");
                            pLane.AddPeople(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("how many?");
                            pLane.KickPeople(Console.ReadLine());
                            break;
                            
                        case 3:
                            Console.WriteLine("how high?");
                            pLane.Ascend(Console.ReadLine());
                            break;
                            
                        case 4:
                            Console.WriteLine("how low?");
                            pLane.Descend(Console.ReadLine());
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("No available choise");
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    CatchActions(e);
                }
            }
        }

        private static void ModifyShip(Ship ship)
        {
           
            while (true)
            {
                Console.WriteLine("You can :\n" +
               "1 - info \n" +
               "2 - add passengers \n" +
               "3 - kick passengers\n" +
               "4 - change port\n" +
               "5 - exit.\n");
                try
                {
                    uint res = Convert.ToUInt32(Console.ReadLine()) - 1;

                    switch (res)
                    {
                        case 0:
                            Console.WriteLine(ship.ToString());
                            break;
                        case 1:
                            Console.WriteLine("how many?");
                            ship.AddPeople(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("how many?");
                            ship.KickPeople(Console.ReadLine());
                            break;

                        case 3:
                            Console.WriteLine("Enter name");
                            ship.Port = Console.ReadLine();
                            break;

                        case 4:
                            return;
                        default:
                            Console.WriteLine("No available choise");
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    CatchActions(e);
                }
            }
        }

        public static void CatchActions(Exception e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
