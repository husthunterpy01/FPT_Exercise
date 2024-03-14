using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
0: Experience
1: Fresher
2: Intern
 */
namespace Ex13
{
    abstract internal class Employee
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public int Phone { get; set; }
        public static int Employee_type { get; set; }
        public static int Employee_count { get; set; }

        public Employee(string id, string fullName, DateTime birthDay, int phone)
        {
            Id = id;
            FullName = fullName;
            BirthDay = birthDay;
            Phone = phone;
        }
        public string ShowInfo()
        {
            return string.Format($"Id {Id} Fullname {FullName} Birthday: {BirthDay} Phone:{Phone} Employee type {Employee_type} Employee count {Employee_count}");
        }
        public abstract void ShowMe();
    }
}
