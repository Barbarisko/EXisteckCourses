using Hometask1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2
{
    public static class TextOutputs
    {
        public  static void PrintMenu()
        {
            Console.WriteLine(" Select Option: \n " +
                                "0 - show list of students \n" +
                                "1 - add new student\n" +
                                "2 - print info about student\n" +
                                "3 -  grade student\n" +
                                "4 - count average grade on subject\n" +
                                "5 - exit");
        }
        public static Student CreateStudent()
        {
            Console.WriteLine("You are about to create a new student. \n Insert Surname, name and lastname: ");
            string fullname = Console.ReadLine();
            string[] fullnamearr = fullname.Split(new char[] { ' ' });

            Console.WriteLine("Specify the group code: ");
            string groupcode = Console.ReadLine();

            return new Student()
            {
                Surname = fullnamearr[0],
                Name = fullnamearr[1],
                Lastname = fullnamearr[2],
                Groupcode = groupcode
            };
        }
        public static void PrintGrades(List<List<uint>> grades)
        {
            var subjcts = Enum.GetValues<Subjects>();

            for (int i = 0; i < grades.Count; i++)
            {
                Console.Write($"\n{subjcts[i]}: ", i);

                for (int j = 0; j < grades[i].Count; j++)
                {
                    Console.Write("{0}{1}", grades[i][j],
                        j == (grades[i].Count - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
        }
        public  static void PrintAllStudents(List<Student> students)
        {
            if(students.Count ==0)
            {
                throw new ArgumentNullException("No students in school!");
            }
            for (int i = 0; i < students.Count; i++)
            {
                PrintOneStudent(i, students);
            }
        }
        public static void PrintOneStudent(int i, List<Student> students)
        {
            Console.Write($"{i + 1}. {students[i].Surname} {students[i].Name} {students[i].Lastname} \n ", i);
        }

    }
}
