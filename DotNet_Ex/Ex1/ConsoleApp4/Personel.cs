// Cán bộ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Personel
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public Personel() { }
        public Personel(string name, int age, string gender, string address) {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address; 
        }

        // Insert information
        public virtual void Input() {
            Console.WriteLine("Enter the full name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your gender");
            gender = Console.ReadLine();
            Console.WriteLine("Enter your address");
            address = Console.ReadLine();
        }

        // Show information
        public virtual void Display() {
            Console.WriteLine("The information is: Name{0}, Age{1}, Gender{2}, Address{3}", name,age,gender, address);
        }
    }
}
