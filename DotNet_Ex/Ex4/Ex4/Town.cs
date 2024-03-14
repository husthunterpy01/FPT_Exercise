using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Town
    {
        List<Family> families;
        public Town()
        {
            this.families = new List<Family>();
        }
        public void ProgramMenu()
        {
            int n;
            do
            {
                Console.WriteLine("Choose a number to continue");
                Console.WriteLine("1.Add information");
                Console.WriteLine("2.Show information");
                Console.WriteLine("3.Exit");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        AddInformation();
                        break;
                    case 2:
                        ShowInformation();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Invalid syntax, please try again");
                        return;
                }
            } while (n != 3);

        }

        // Add information
        public void AddInformation()
        {
            Console.WriteLine("Enter the NoAddress of the family");
            var homeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of members in the family");
            var noMembers = Convert.ToInt32(Console.ReadLine());
            List<Person> per = new List<Person>();
       
            for (int i = 0; i < noMembers; i++)
            {
                Person p = new Person();
                Console.WriteLine("Enter the name:");
                p.Name = Console.ReadLine();
                Console.WriteLine("Enter the age:");
                p.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the job");
                p.Job = Console.ReadLine();
                Console.WriteLine("Enter the personal Id:");
                p.Id = Console.ReadLine();
                per.Add(p);
            }
            Family f = new Family();
            f.person = per;
            f.NoPersons = noMembers;
            f.NoAddress = homeId;
            families.Add(f);
        }

        public void ShowInformation()
        {
            Console.WriteLine("Enter the number of families that you want to see the information: ");
            var n = Convert.ToInt32(Console.ReadLine());
            foreach (var fam in families)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(fam.ToString());
                }
            }

        }
    }
}
