using System;
using System.Collections.Generic;

namespace Hometask3
{
    //Розробити додаток «Прайс-лист», яке формує список носіїв інформації,
    // - Flash-пам'ять,
    // - DVD - диск,
    // - знімний HDD.
    // Кожен носій інформації є об'єктом відповідного класу:
    // - Клас Flash - пам'ять;
    // - Клас DVD - диск;
    // - Клас знімний HDD.
    // Всі три класи є похідними від абстрактного класу «Носій інформації».
    // Базовий клас містить наступні поля: найменування носія, ім'я виробника, модель, кількість, ціна.
    // Клас має всі необхідні властивості для доступу до полів, а також віртуальними методами:
    // друку, імітація завантаження з файлу і збереження в файл. У похідних класах перевизначаються методи друку, завантаження і збереження.
    // Крім того, кожен з похідних класів доповнюється такими полями:
    // - Клас Flash-пам'ять: обсяг пам'яті, швидкість USB;
    // - Клас знімний HDD: розмір диска, швидкість USB;
    // - Клас DVD - диск: швидкість читання і швидкість запису.
    // Робота з об'єктами відповідних класів проводиться через посилання на базовий клас, які зберігаються в списку.
    // Додаток має надавати такі можливості:
    // - додавання носія інформації в список;
    // - видалення носія інформації зі списку по заданому критерію;
    // - друк списку;
    // - зміна певних параметрів носія інформації;
    // - пошук носія інформації за заданим критерієм;

    class Program
    {
        static void Main(string[] args)
        {
            var plist = Init();
            while (true)
            {
                Console.WriteLine("Hi, this is the electronic store price list. See what we have:\n");
                plist.PrintDrives();

                Console.WriteLine("This you can do with the list:\n" +
                                    "1 - Add new item \n" +
                                    "2 - search item by input text\n");
                try
                {
                    string ans = Console.ReadLine();
                    if (ans == "1")
                    {
                        Console.WriteLine("Choose a drive to add:\n" +
                            "1 - HDD\n" +
                            "2 - DVD\n" +
                            "3 - Flash\n");
                        var res = Convert.ToInt32(Console.ReadLine());
                        var basics = CreateBasicDrive();
                        try
                        {
                            CreateSpecifiedDrive(res, basics, plist);
                            Console.WriteLine("Created!");

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadKey();
                            Console.Clear();
                        }

                    }

                    else if (ans == "2")
                    {
                        Console.WriteLine("input text to start search");

                        var input = Console.ReadLine();
                        var drive = plist.SearchThroughDrives(input);
                        plist.PrintDrive(drive);

                        Console.WriteLine("Need to delete it? [y/n]");
                        var answ = Console.ReadLine();
                        if (answ == "y" || answ == "yes")
                        {
                            plist.DeleteDrive(drive);
                            Console.WriteLine($"drive deleted!");
                        }

                        Console.ReadKey();
                        Console.Clear();

                    }

                    else throw new KeyNotFoundException("no other options");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            

        }
        public static string[] CreateBasicDrive()
        {
            Console.WriteLine("Please input standart characteristics for an InfoCarrier:\n" +
                "name: ");
            var name = Console.ReadLine();

            Console.WriteLine("manufacturer name:");
            var manufacturer_name = Console.ReadLine();

            Console.WriteLine("model:");
            var model = Console.ReadLine();

            Console.WriteLine("quantity to supply:");
            var quantity = Console.ReadLine();

            Console.WriteLine("price for 1:");
            var price = Console.ReadLine();

            return new string[5] {name, manufacturer_name, model, quantity, price };
        }
        public static void CreateSpecifiedDrive(int res, string[] basics, Pricelist plist)
        {
            InfoCarrier drive;

            switch (res)
            {
                case 1:
                    Console.WriteLine("Also, please provide disk capacity:");
                    var disk_cap = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine("...and USB speed");
                    var usb_speed = Convert.ToUInt32(Console.ReadLine());
                    drive = new HDD(disk_cap, usb_speed)
                    {
                        Name = basics[0],
                        ManufacturerName = basics[1],
                        Model = basics[2],
                        Quantity = Convert.ToInt32(basics[3]),
                        Price = Convert.ToInt32(basics[4])
                    };

                    plist.AddDrive(drive);
                    break;
                case 2:
                    Console.WriteLine("Also, please provide read_speed:");
                    var read_speed = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine("...and write_speed ");
                    var write_speed = Convert.ToUInt32(Console.ReadLine());
                    drive = new DVD(read_speed, write_speed)
                    {
                        Name = basics[0],
                        ManufacturerName = basics[1],
                        Model = basics[2],
                        Quantity = Convert.ToInt32(basics[3]),
                        Price = Convert.ToInt32(basics[4])
                    };
                    plist.AddDrive(drive);

                    break;
                case 3:
                    Console.WriteLine("Also, please provide memory capacity:");
                    var mem_cap = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine("...and USB speed");
                    var usb_sped = Convert.ToUInt32(Console.ReadLine());
                    drive = new Flash(mem_cap, usb_sped)
                    {
                        Name = basics[0],
                        ManufacturerName = basics[1],
                        Model = basics[2],
                        Quantity = Convert.ToInt32(basics[3]),
                        Price = Convert.ToInt32(basics[4])
                    };
                    plist.AddDrive(drive);

                    break;
                default:
                    Console.WriteLine("no other options");
                    break;
            }
        }
        public static Pricelist Init()
        {
            Pricelist pricelist = new Pricelist();
            InfoCarrier hdd = new HDD(512, 12) { Name = "HDD", ManufacturerName = "Transcend", Model = "Portable", Quantity = 2, Price = 400 };
            InfoCarrier dvd = new DVD(1352, 1000) { Name = "DVD", ManufacturerName = "Panasonic", Model = "Blu-ray", Quantity = 4, Price = 160 };
            InfoCarrier flash = new Flash(64, 25) { Name = "Flashdrive", ManufacturerName = "Kingston", Model = "Extra-fast", Quantity = 3, Price = 450 };
            pricelist.Drives.Add(hdd);
            pricelist.Drives.Add(dvd);
            pricelist.Drives.Add(flash);
            return pricelist;
        }
    }


}
