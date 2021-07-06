using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask3
{
    //найменування носія, ім'я виробника, модель, кількість, ціна.
    // Клас має всі необхідні властивості для доступу до полів, а також віртуальними методами:
    // друку, імітація завантаження з файлу і збереження в файл. У похідних класах перевизначаються методи друку, завантаження і збереження.

    public abstract class InfoCarrier
    {
        private string name;
        private string manufacturerName;
        private string model;
        private int quantity;
        private int price;

        public string Name { get => name; set => name = value; }
        public string ManufacturerName { get => manufacturerName; set => manufacturerName = value; }
        public string Model { get => model; set => model = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }

        public virtual void PrintInfo(InfoCarrier carrier) { }
        public virtual void DownloadInto(InfoCarrier carrier) { }
        public virtual void Save(InfoCarrier carrier) { }
            
    }
}
