using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Family
    {
        public int NoPersons { get; set; }
        public int NoAddress { get; set; }
        public List<Person> person { get; set; }
        public Family()
        {
            this.person = new List<Person>();
        }
        public override string ToString()
        {
            NoPersons = this.person.Count;
            string membersInfo = string.Join("\n", person.Select(p => p.ToString()));
            return string.Format($"The Family at address {NoAddress} has {NoPersons} people.\nMembers information:\n{membersInfo}");
        }
    }
}
