using Hometask1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2
{
    public interface IStudentService
    {
        void SetGrade(uint grade, uint subject);
        decimal CountAverageGrade(List<uint> grades);
        string PrintStudentInfo(List<Student> students, int id);
    }
}
