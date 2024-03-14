using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    internal class Intern : Employee
    {
        public string Majors { get; set; }
        public int Semester { get; set; }
        public string University_name { get; set; }

        public Intern(string id, string fullName, DateTime birthDay, int phone, string majors, int semester, string university_name) : base(id, fullName,birthDay, phone)
        {
            Employee_type = 2;
            Majors = majors;
            Semester = semester;
            University_name = university_name;
        }

        public override void ShowMe() {
            Console.WriteLine("Hello");
        }
    }
}
