
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    internal class FormalStudent : Student
    {
        public FormalStudent()
        {

        }
        public FormalStudent(string id, string name, DateTime dob, int yearIn, float inScore, List<Result> result, string studentEduType) : base(id,name, dob,yearIn, inScore, result,studentEduType)
        {

        }
        public FormalStudent(FormalStudent fstu) :base(fstu) 
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

}
