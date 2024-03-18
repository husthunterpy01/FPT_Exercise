using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex15
{
    abstract class Student : IComparer<Student>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public int YearIn { get; set; }
        public float InScore { get; set; }
        public List<Result> result { get; set; }
        public string StudentEduType { get; set; }
        public static int studentNum;
        public Student()
        {

        }
        public Student(string id, string name, DateTime dob, int yearIn, float inScore, List<Result> result, string studentEduType)
        {
            Id = id;
            Name = name;
            Dob = dob;
            YearIn = yearIn;
            InScore = inScore;
            this.result = result;
            StudentEduType = studentEduType;
            studentNum++;
        }

        public Student(Student stu)
        {
            Id = stu.Id;
            Name = stu.Name;
            Dob = stu.Dob;
            YearIn = stu.YearIn;
            InScore = stu.InScore;
            this.result = stu.result;
            StudentEduType = stu.StudentEduType;
        }

        // Year enrolled in descending order, student edu type in ascending order
        public int Compare(Student x, Student y)
        {
            var studentType = x.StudentEduType.CompareTo(y.StudentEduType);
            if (studentType != 0)
            {
                return studentType;
            }

            return y.YearIn - x.YearIn;   
        }

        public override string ToString()
        {
            return string.Format($"The student Id{Id} Name{Name} Birthday{Dob} YearIn{YearIn} InScore{InScore} Result: {result} Education Type: {StudentEduType}");
        }
    }
}
