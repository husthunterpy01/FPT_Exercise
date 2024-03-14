using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Origin { get; set; }
        public string ClassStudent { get; set; }
        public Student()
        {

        }
        public override string ToString()
        {
            return string.Format($"Name: {Name} Age: {Age} Origin: {Origin} Class:{ClassStudent}");
        }
    }
}
