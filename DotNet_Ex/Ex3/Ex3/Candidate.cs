using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    abstract internal class Candidate
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String StudentType { get; set; }
        public int Priority { get; set; }

        public Candidate()
        {
        }

        public Candidate(int id, string name, string address, int priority, string studentType)
        {
            Id = id;
            Name = name;
            Address = address;
            Priority = priority;
            StudentType = studentType;
        }
    }
}
