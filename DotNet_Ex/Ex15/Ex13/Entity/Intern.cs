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
        public Intern()
        {

        }
        public Intern(string id, string fullName, DateTime birthDay, string email, int phone, List<Certificate> certificate, string majors, int semester, string university_name) : base(id, fullName, birthDay, email, phone, certificate)
        {
            Employee_type = 2;
            Majors = majors;
            Semester = semester;
            University_name = university_name;
        }

        public override string ShowMe()
        {
            string employeeInfo = $"Id {Id} Fullname {FullName} Birthday: {BirthDay} Email: {Email} Phone:{Phone} Employee type {Employee_type} Majors {Majors} Semester {Semester} University Name {University_name}";
            if (CertificateList != null && CertificateList.Count > 0)
            {
                string certificateInfo = "Certificate details:";
                for (int i = 0; i < CertificateList.Count; i++)
                {
                    Certificate cert = CertificateList[i];
                    certificateInfo += $"\nCertificate {i + 1}: Id {cert.CertificateId}, Name {cert.CertificateName}, Rank {cert.CertificateRank}, Date {cert.CertifcatedDate}";
                }
                return $"{employeeInfo}\n{certificateInfo}";
            }
            else
            {
                return employeeInfo;
            }
        }

    }
}
