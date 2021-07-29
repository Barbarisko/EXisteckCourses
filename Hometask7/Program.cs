using FluentMigrator.Runner.Generators.Generic;
using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Hometask7
{
   class Program
    {
        static void Main(string[] args)
        {
            var fs = new FileStream("studen.cs", FileMode.Create, FileAccess.Write);
            var bs = new BinaryFormatter();

            var student = Init(bs, fs);
            try
            {
                Console.WriteLine($"Current Dir: {Directory.GetCurrentDirectory()}");

                fs = new FileStream("studen.cs", FileMode.Open, FileAccess.ReadWrite);
                var dsStudent = (Student)bs.Deserialize(fs);

                GenericFileGenerator<Student>.PrintPorps(dsStudent.GetType(), dsStudent);
                GenericFileGenerator<Student>.WriteStudentAsync(GenericFileGenerator<Student>.WritePorps(dsStudent.GetType(), student ));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        private static Student Init(BinaryFormatter bs, FileStream fs)
        {
            object teachObj = new Teacher() { Name = "Teacher1", Subject = "Math"};
            object obj = new Student { Name = "St1", teacher = teachObj as Teacher};

            bs.Serialize(fs, obj);
            fs.Close();
            Console.WriteLine("OK");

            var type = obj.GetType();
            Console.WriteLine($"Type: {type.FullName}");

            var atr = type.GetCustomAttributes(false);

            var upperAtr = atr.FirstOrDefault(at => at is UpperCaseAttribute);

            if (upperAtr != null)
            {
                var attribute = upperAtr as UpperCaseAttribute;

                var s = attribute.IsUpperCase;
                Console.WriteLine($"Attribute :[{attribute.ToString()}]\n");
            }

            return obj as Student;
        }

    }
}
