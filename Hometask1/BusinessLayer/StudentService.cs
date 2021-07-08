using Hometask1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2
{
    public class StudentService:IStudentService
    {
        private Student student;
        public void SetGrade(uint grade, uint subject)
        {
            int i = (int)subject - 1;

            if (subject > Enum.GetValues<Subjects>().Length)
            {
                throw new ArgumentNullException("No such digit");
            }

            if (!Convert.ToString(grade).All(char.IsDigit))
            {
                throw new ArgumentNullException("This is not a digit");
            }
            
            student.Grades[i].Add(grade);                              
        }

        public decimal CountAverageGrade(List<uint> grades)
        {
            if(grades.Count == 0)
            {
                throw new ArgumentNullException("No elements to count");
            }

            uint sum = 0;
            for (int i = 0; i <= grades.Count - 1; i++)
            {
                sum += grades[i];
            }

            return sum / grades.Count;
        }
        public string PrintStudentInfo(List<Student> students, int id)
        {
            if (!students.Contains(students[id]))
            {
                throw new KeyNotFoundException("No such student!");
            }
            else
            {
                return $"Student {students[id].Surname} {students[id].Name} \n " +
                        $"Group {students[id].Groupcode} \n  " +
                        $"Grades \n ";
            }
        }
    }
}
