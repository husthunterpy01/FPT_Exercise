// Kỹ sư 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Engineer : Personel
    {
        public string prof { get; set; }
        public Engineer() { }
        public Engineer(string name, int age, string gender, string address, string prof) : base(name, age, gender, address) 
        {
            this.prof = prof;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter professional:");
            prof = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("The role is: Engineer");
            Console.WriteLine("Professional is:  " + prof);
        }
    }
}
