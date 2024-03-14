// Quản lý 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /*
      1. Add Personel
      2. Search by name
     `3. Show information about list of Personel
      4. Escape from the program
     */
    internal class Manager
    {
        // Using List to store information
        private List<Personel> p = new List<Personel>();
        public Manager() { }
        public void programMenu() {
            int num;
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Welcome to our system, please choose a number to continue");
            do
            {
                Console.WriteLine("1. Add new personel worker");
                Console.WriteLine("2. Search personel information");
                Console.WriteLine("3. Show list of personel");
                Console.WriteLine("4. Escapse the program");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num) {
                    case 1:
                        addList();
                        break;

                    case 2:
                        searchList();
                        break;

                    case 3:
                        showList();
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Invalid number, please try again!");
                        break;
                }

            } while (num != 4);
        }

        // Add Personel to the system
        public void addList() {
            int num;
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Choose the position you want to add: ");
         do
            {
                Console.WriteLine("1. Worker");
                Console.WriteLine("2. Engineer");
                Console.WriteLine("3. Employee");
                Console.WriteLine("4. Exit");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num) {
                    case 1:
                        Worker w = new Worker();
                        w.Input();
                        p.Add(w);
                        Console.WriteLine("Adding complete, do you want to add more ?");
                        break;

                    case 2:
                        Engineer e1 = new Engineer();
                        e1.Input();
                        p.Add(e1);
                        Console.WriteLine("Adding complete, do you want to add more ?");
                        break;

                    case 3:
                        Employee e2 = new Employee();
                        e2.Input();
                        p.Add(e2);
                        Console.WriteLine("Adding complete, do you want to add more ?");
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Invalid number, please try again");
                        break;
                }
        } 
            while (num != 4) ;

        }

        // Search personnel by name
        public void searchList()
        {
            String namePer;
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Enter the name you want to search");
            namePer = Console.ReadLine();
            for (int i = 0; i < p.Count; i++) {
                if (p[i].name.Equals(namePer))
                {
                    Console.WriteLine(p[i]);
                }
                else {
                    Console.WriteLine("No name found");
                }
                }
            }

        // Show the list of personnel
        public void showList()
        {
            if (p.Count == 0)
            {
                Console.WriteLine("No members yet, please add member");
            }
            else {
                for (int i = 0; i < p.Count; i++)
                {
                    p[i].Display();
                }
            }
        }
    }
}
