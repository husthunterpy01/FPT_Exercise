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
        public Experience()
        {

        }
        public Experience(string id, string fullName, DateTime birthDay, string email, int phone, List<Certificate> certificate, int expInYear, string proSkill) : base(id, fullName, birthDay, email, phone, certificate)
        {
            Employee_type = 0;
            ExpInYear = expInYear;
            ProSkill = proSkill;
        }

        public override string ShowMe()
        {
            string employeeInfo = $"Id {Id} Fullname {FullName} Birthday: {BirthDay} Email: {Email} Phone:{Phone} Employee type {Employee_type} ExpInyear {ExpInYear} Pro_skill {ProSkill}";
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
