using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask7
{
    [Serializable]
    public class Student
    {
        private readonly Guid _id;
        [UpperCase(IsUpperCase = true)]
        public string Name { get; set; }
        public DateTime GradYear { get; set; }
        public Teacher teacher { get; set; }

        public Student()
        {
            _id = Guid.NewGuid();

            GradYear = DateTime.Now;
        }

        public void SetAuthor(Teacher _teacher)
        {
            teacher = _teacher;
        }
        public Guid GetId() => _id;
    }

}
