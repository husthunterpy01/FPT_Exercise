using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class CandidateA : Candidate
    {
        public const string MATH = "Math";
        public const string PHYSICS = "Physics";
        public const string CHEMISTRY = "Chemistry";
        public CandidateA()
        {
        }
        public CandidateA(int id, string name, string address, int priority, string studentType) : base(id, name, address, priority, studentType)
        {
        }
    }
}
