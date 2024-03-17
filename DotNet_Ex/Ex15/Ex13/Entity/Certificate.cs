using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    internal class Certificate
    {
        public string CertificateId { get; set; }
        public string CertificateName { get; set; }
        public int CertificateRank { get; set; }
        public DateTime CertifcatedDate { get; set; }
        public Certificate()
        {
        
        }
        public Certificate(string id, string name, int rank, DateTime date)
        {
            CertificateId = id;
            CertificateName = name;
            CertificateRank = rank;
            CertifcatedDate = date;
        }
    }
}
