using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask7
{
    //    Створити generic клас що дозволяє в залежності переданого типу(іншого класу) створити файл з розширення cs
    //    де буде міститись код з назвою переданого класу і його властивостями.
    //    Потрібно врахувати що властивості можуть бути з set і без нього або з приватним set. 
    //Для кожного переданого класу створювати окремий файл
    //якщо файл з таким іменем вже існує то варто запитати користувача чи перезаписати існуючий файл
    //чи створити ще один - назва класу + номер файлу (Huma.cs, Human_1.cs...etc.)
    public static class GenericFileGenerator<T>
    {
        private static T obj { get; set; }

        public static async Task WriteStudentAsync(string[] code)
        {
            int count = 0;
            
            if (!File.Exists($"student{count}.cs"))
            {
                File.Create($"student{count}.cs");
            }
            else
            {
                count += 1;
                File.Create($"student{count}.cs");
            }
            await File.WriteAllLinesAsync($"student{count}.cs", code);
        }


        public static void PrintPorps(Type type, object obj)
        {
            Console.WriteLine($"Class {nameof(type)} \n [ ");
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine($"{property.PropertyType.FullName} {property.Name} : {property.GetValue(obj)}\n");
            }
            Console.WriteLine("]");
        }
        public static string[] WritePorps(Type type, object obj)
        {
            var properties = type.GetProperties();
            string[] code = new string[properties.Length];
            code[0] = $"{nameof(type.FullName)} \n [";
            
            for(int i = 0; i< properties.Length; i++)
            {
                code[i + 1] = $"{properties[i].PropertyType.FullName} {properties[i].Name} : {properties[i].GetValue(obj)}\n";
            }
            code.Append("]");

            return code;
        }

    }
}
