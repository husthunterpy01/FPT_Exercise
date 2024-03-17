using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    abstract class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public int YearIn { get; set; }
        public float InScore { get; set; }
        List<Result> result { get; set; }
    }
}
