using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask7
{
    [Serializable]
    public class Teacher
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        private int  YearOfBirth { get; set; }
    }
}
