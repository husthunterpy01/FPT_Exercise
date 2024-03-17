using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    internal class OfficeStudent : Student
    {
        public string OfficeLinkDest { get; set; }
        public OfficeStudent(string id, string name, DateTime dob, int yearIn, float inScore, List<Result> result, string studentEduType, string officeaddr) : base(id, name, dob, yearIn, inScore, result, studentEduType)
        {
            OfficeLinkDest = officeaddr;
        }
        public OfficeStudent(OfficeStudent officestudent) : base(officestudent)
        {
            OfficeLinkDest = officestudent.OfficeLinkDest;
        }
        public override string ToString()
        {
            var a = base.ToString();
            a += string.Format($"Office Address {OfficeLinkDest}");
            return a;
        }
    }
}
