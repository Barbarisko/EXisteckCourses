using Hometask1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2
{
    public class StudentController
    {
        IStudentService studentService;
        School school;
        public StudentController()
        {
            studentService = new StudentService();
            school = new School();
        }

        public void EnableActions()
        {
            while (true)
            {
                TextOutputs.PrintMenu();

                try
                {
                    string res = Console.ReadLine();

                    Swithc(Convert.ToInt32(res), school.students);

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

        private void Swithc(int res, List<Student> students)
        {
            switch (res)
            {
                case 0:
                    TextOutputs.PrintAllStudents(students);
                    break;

                case 1:
                    students.Add(TextOutputs.CreateStudent());
                    Console.WriteLine("Student created!");                        
                    break;

                case 2:
                    Console.WriteLine("Input student id: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    TextOutputs.PrintOneStudent(index, students);
                    TextOutputs.PrintGrades(students[index].Grades);
                    break;

                case 3:
                    Console.WriteLine("Input student id: ");
                    int indx = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Select the subject: \n" +
                                        "1 - proga\n" +
                                        "2 - management\n" +
                                        "3 - design\n ");
                    uint subj = Convert.ToUInt32(Console.ReadLine());

                    Console.WriteLine("Give a grade: ");
                    uint grade = Convert.ToUInt32(Console.ReadLine());

                    students[indx].SetGrade(grade, subj);
                    TextOutputs.PrintGrades(students[indx].Grades);

                    break;
                case 4:
                    Console.WriteLine("Input student's id: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Select the subject: \n" +
                                       "1 - proga\n" +
                                       "2 - management\n" +
                                       "3 - design\n ");
                    int subject = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Average grade: " +
                        $"{studentService.CountAverageGrade(school.students[id].Grades[subject-1])}");
                   break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No available choise");
                    break;
            }
        }
        public void CatchActions(Exception e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
