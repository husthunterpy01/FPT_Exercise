using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Entity
{
    internal class ListCompare : IComparer<Student>
    {
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
    }
}
