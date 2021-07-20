using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    // Робота з об'єктами відповідних класів проводиться через посилання на базовий клас, які зберігаються в списку.
    // Додаток має надавати такі можливості:
    // - додавання носія інформації в список;
    // - видалення носія інформації зі списку по заданому критерію;
    // - друк списку;
    // - зміна певних параметрів носія інформації;
    // - пошук носія інформації за заданим критерієм;

    public class Pricelist
    {
        private List<InfoCarrier> drives;

        public List<InfoCarrier> Drives { get => drives; set => drives = value; }

        public Pricelist()
        {
            drives = new List<InfoCarrier>();
        }

        public void AddDrive(InfoCarrier drive)
        {
            if (drive != null) drives.Add(drive);
            else throw new ArgumentNullException("no drive created, will not be added;");
        }

        public InfoCarrier SearchThroughDrives(string input)
        {
            if (input != null)
            {
                foreach (var drive in drives)
                {
                    foreach (PropertyInfo prop in drive.GetType().GetProperties())
                    {
                        //var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                        var prop_value = prop.GetValue(drive, null).ToString();
                        if (prop_value.Contains(input))
                        {
                            //Console.WriteLine(prop.GetValue(drive, null).ToString());
                            PrintDrive(drive);
                            return drive;
                        }
                    }

                }
            }            
            return null;
        }

        public void DeleteDrive(InfoCarrier drive)
        {
            if (drive != null) drives.Remove(drive);
            else throw new ArgumentNullException("no drive given, will not be deleted;");
        }


        public static void PrintDrive(InfoCarrier drive)
        {
            Console.WriteLine(drive.Name);
            Console.WriteLine(drive.Model);
            Console.WriteLine(drive.ManufacturerName);
            Console.WriteLine(drive.Price);
            Console.WriteLine(drive.Quantity);

            if (drive is HDD hdd)
            {
                Console.WriteLine($"Disk capacity: {hdd.DiskCapacity} Gb\n USB Speed: {hdd.USBSpeed} Mbps\n");
            }

            if (drive is DVD dvd)
            {
                Console.WriteLine($"Read Speed: {dvd.ReadSpeed} Mbps \n Write Speed: {dvd.WriteSpeed} Mbps\n");
            }
            if (drive is Flash flash)
            {
                Console.WriteLine($"Memory capacity: {flash.MemoryCapacity} \n USB Speed: {flash.USBSpeed} \n");
            }
       }
        public void PrintDrives()
        {
            if (drives.Count == 0)
            {
                throw new ArgumentNullException("no items to print");
            }
            foreach (InfoCarrier drive in drives)
            {
                PrintDrive(drive);
            }
        }
    }
}
