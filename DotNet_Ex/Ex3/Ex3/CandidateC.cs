using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class CandidateC : Candidate
    {
        public const string LITERATURE = "Literature";
        public const string HISTORY = "History";
        public const string GEOGRAPHY = "Geography";
        public CandidateC()
        {
        }
        public CandidateC(int id, string name, string address, int priority, string studentType) : base(id, name, address, priority, studentType)
        {
        }
    }
}
