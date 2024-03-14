// Công nhân
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Worker : Personel
    {
        public int rank { get; set; }

        public Worker() { }
        public Worker(string name, int age, string gender, string address, int rank) : base(name, age, gender, address)
        {
            this.rank = rank;
        }
        public override void Input() {
            base.Input();
            Console.WriteLine("Enter the rank of the worker: ");
            rank = Convert.ToInt32(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("The role is: Worker");
            Console.WriteLine("Rank is: " + rank);
            
        }
    }
}
