using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class CandidateB : Candidate
    {
        public const string MATH = "Math";
        public const string BIOLOGY = "Biology";
        public const string CHEMISTRY = "Chemistry";
        public CandidateB()
        {
        }
        public CandidateB(int id, string name, string address, int priority, string studentType) : base(id, name, address, priority, studentType)
        {
        }
    }
}
