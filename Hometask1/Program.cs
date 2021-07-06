using System;
using System.Collections.Generic;

namespace Hometask1
{
    public class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            Console.WriteLine("Hi! You are about to create a new student. \n Insert Surname, name and lastname: ");
            string fullname = Console.ReadLine();
            string[] fullnamearr = fullname.Split(new char[] { ' ' });

            //Console.WriteLine("Specify the group code: ");
            //string groupcode = Console.ReadLine();

            school.students.Add(new Student()
            {
                Surname = fullnamearr[0],
                ////Name = fullnamearr[1],
                //Lastname = fullnamearr[2],
                //Groupcode = groupcode
            });
            
            Console.WriteLine("Select the subject: " +
                                "1 - proga\n" +
                                "2 - management\n" +
                                "3 - design\n ");
            uint subj = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Give a grade: ");
            uint grade = Convert.ToUInt32(Console.ReadLine());

            school.students[0].SetGrade(grade, subj);

            //foreach (Student s in school.students)
            //{

            //    Console.WriteLine(s.Lastname +"\n");

            for (int i = 0; i < school.students[0].Grades.Length; i++)
            {
                Console.Write("Element({0}): ", i);

                for (int j = 0; j < school.students[0].Grades[i].Length; j++)
                {
                    Console.Write("{0}{1}", school.students[0].Grades[i][j], 
                        j == (school.students[0].Grades[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
            //}

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
