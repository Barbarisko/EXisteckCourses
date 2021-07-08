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
        Programming, 
        Management, 
        Design
    }
    public class Student
    {
        private string surname;
        private string name;
        private string lastname;
        private string groupcode;
        private uint age;
        private List<List<uint>> grades;

        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Groupcode { get => groupcode; set => groupcode = value; }
        public uint Age { get => age; set => age = value; }
        public List<List<uint>> Grades { get => grades; set => grades = value; }

        public Student()
        {
            Grades = new List<List<uint>>
            {
                new List<uint>(),
                new List<uint>(),
                new List<uint>()
            };            
        }

        public Student(string _surname, string _name, string _lastname, uint _age)
        {

        }


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

            Grades[i].Add(grade);
        }
    }

}
