using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    internal class Experience : Employee
    {
        public int ExpInYear { get; set; }
        public string ProSkill { get; set; }
        public Experience(string id, string fullName, DateTime birthDay, int phone, int expInYear, string proSkill) : base(id, fullName, birthDay, phone)
        {
            Employee_type = 0;
            ExpInYear = expInYear;
            ProSkill = proSkill;
        }
 
        public override void ShowMe() { }
    }
}
