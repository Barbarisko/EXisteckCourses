using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask1
{
    //Придумати клас  студента.
    //І передбачити  в ньому  наступні моменти:
    //      властивості:
    //          прізвище, ім'я, по батькові, група, вік, вкладений масив оцінок по програмуванню, адмініструванню й дизайну.
    //А також додати методи по  роботі  з перерахованими  даними:
    //      можливість  встановлення/одержання оцінки,
    //      одержання середнього бала по даному предметі,
    //      роздруківка даних про студента.

    enum Subjects
    {
        programming, 
        management, 
        design
    }
    public class Student
    {
        private string surname;
        private string name;
        private string lastname;
        private string groupcode;
        private uint age;
        private uint[][] grades;

        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Groupcode { get => groupcode; set => groupcode = value; }
        public uint Age { get => age; set => age = value; }
        public uint[][] Grades { get => grades; set => grades = value; }

        public Student()
        {
            Grades = new uint[3][]
            {
                new uint[0] {},
                new uint[0] {},
                new uint[0] {}
            };
            
        }
        public Student(string _surname, string _name, string _lastname, uint _age)
        {

        }

        public void SetGrade(uint grade, uint subject)
        {
            int i = Convert.ToInt32(subject)-1;

            if(subject>Enum.GetValues<Subjects>().Length)
            {
                      throw new ArgumentNullException("No such digit");
            }
            if (Convert.ToString(grade).All(char.IsDigit))
            {
                //uint g = Convert.ToUInt32(grade);
                Grades[i].Append(grade);
            }
            else
            {
                throw new ArgumentNullException("This is not a digit");
            }
            //if (Enum.IsDefined(typeof(Subjects), i))
            //{
            //    if (grade.All(char.IsDigit))
            //    {
            //        uint g = Convert.ToUInt32(grade);
            //        Grades[i](g);
            //    }
            //    else
            //    {
            //        throw new ArgumentNullException("This is not a digit");
            //    }
            //}            
        }

        public decimal CountAverageGrade(uint[] grades)
        {
            return 0;
        }
        public void PrintStudentInfo(int id)
        {
             
        }
    }

}
