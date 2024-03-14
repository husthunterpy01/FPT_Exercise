using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }
        public string Id { get; set; }


        public Person()
        {

        }
        public override string ToString()
        {
            return string.Format($"The name is {Name} with Age {Age} and Job {Job} and Id {Id}");
        }
    }
}
