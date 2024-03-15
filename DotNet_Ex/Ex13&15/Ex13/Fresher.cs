using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    internal class Fresher : Employee
    {
        public DateTime Graduation_date { get; set; }
        public string Graduation_rank { get; set; }
        public string Education { get; set; }
        public Fresher()
        {

        }
        public Fresher(string id, string fullName, DateTime birthDay, string email, int phone, List<Certificate> certificate, DateTime graduation_date, string graduation_rank, string education) : base(id, fullName, birthDay, email, phone, certificate)
        {
            Employee_type = 1;
            Graduation_date = graduation_date;
            Graduation_rank = graduation_rank;
            Education = education;
        }
        public override string ShowMe()
        {
            string employeeInfo = $"Id {Id} Fullname {FullName} Birthday: {BirthDay} Email: {Email} Phone:{Phone} Employee type {Employee_type} Graduation date {Graduation_date} Graduation rank {Graduation_rank} Education {Education}";
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
