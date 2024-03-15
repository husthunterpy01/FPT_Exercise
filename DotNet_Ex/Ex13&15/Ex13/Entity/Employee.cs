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
        public string Email { get; set; }
        public int Phone { get; set; }
        public static int Employee_type { get; set; }
        public static int Employee_count { get; set; } = 0;
        public List<Certificate> CertificateList { get; set; }
        public Employee()
        {
            Employee_count++;
        }
        public Employee(string id, string fullName, DateTime birthDay, string email, int phone, List<Certificate> certificate)
        {
            Id = id;
            FullName = fullName;
            BirthDay = birthDay;
            Email = email;
            Phone = phone;
            CertificateList = certificate;
            Employee_count++;
        }

        public string ShowInfo()
        {
            return string.Format($"Id {Id} Fullname {FullName} Birthday: {BirthDay} Email: {Email} Phone:{Phone} Employee count {Employee_count}");
        }
        public abstract string ShowMe();
    }
}
