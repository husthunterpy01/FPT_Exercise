using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    internal class Fresher:Employee
    {
        public DateTime Graduation_date { get; set; }
        public string Graduation_rank { get; set; }
        public string Education { get; set; }
   
        public Fresher(string id, string fullName, DateTime birthDay, int phone, DateTime graduation_date, string graduation_rank, string education) : base(id, fullName, birthDay, phone)
        {
            Employee_type = 1;
            Graduation_date = graduation_date;
            Graduation_rank = graduation_rank;
            Education = education;
        }
        public override void ShowMe() { }

    }
}
