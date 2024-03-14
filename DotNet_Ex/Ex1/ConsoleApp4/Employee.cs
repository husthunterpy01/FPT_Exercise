// Nhân viên
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Employee : Personel
    {
        public string job { get; set; }
        public Employee() { }
        public Employee(string name, int age, string gender, string address, string job) : base(name, age, gender, address) {
            this.job = job;       
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter the job of Employee: ");
            job = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("The role is: Employee");
            Console.WriteLine("Job is: " + job);
        }
    }
}
