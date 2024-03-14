using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class School
    {
        List<Student> stu = new List<Student>();

        // Main Screen
        public void ProgramMenu()
        {
            int num;
            do
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Welcome to our system, choose a number to continue");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Show student information");
                Console.WriteLine("3. Search student by given information");
                Console.WriteLine("4. Exit");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("You have chosen to add student");
                        AddStudent();
                        break;
                    case 2:
                        Console.WriteLine("You have chosen to show student information");
                        ShowStudentInfo();
                        break;
                    case 3:
                        Console.WriteLine("You have chosen to search student through given information");
                        ShowStudentCategorization();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Inavlid number, please try again");
                        return;
                }
            } while (num != 4);
        }


        // Add student
        public void AddStudent()
        {
            Student student = new Student();
            Console.WriteLine("Enter the name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter the age:");
            student.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the originality of the student:");
            student.Origin = Console.ReadLine();
            Console.WriteLine("Enter the student class:");
            student.ClassStudent = Console.ReadLine();
            stu.Add(student);
        }

        // Show all student information
        public void ShowStudentInfo()
        {
            if (stu.Count == 0)
            {
                Console.WriteLine("The list does not have any student please add them");
            }
            else
            {
                foreach (Student student1 in stu)
                {
                    Console.WriteLine(student1.ToString());
                }
            }
        }

        // Show student information through categorization
        public void ShowStudentCategorization()
        {
            int n;
            do
            {
                Console.WriteLine("++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("Search by Age or through Age and Originality, choose a number");
                Console.WriteLine("1. Age 20 search");
                Console.WriteLine("2. Age 23 and Originality DN search");
                Console.WriteLine("3. Exit");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("20 year old student list:");
                        AgeSearch(stu);
                        break;

                    case 2:
                        Console.WriteLine("23 year old student with DN originality count");
                        Console.WriteLine(AgeAndOriginSearch(stu));
                        break;

                    default:
                        Console.WriteLine("Invalid number, please try again");
                        return;
                }
            } while (n != 3);
        }
        // Search by Age 20
        public void AgeSearch(List<Student> stu)
        {
            if (stu.Where(stu => stu.Age == 20).Count() == 0)
            {
                Console.WriteLine("No student found");
            }
            else
            {
                var stu1 = stu.Where(stu => stu.Age == 20).ToList();
                foreach (var j in stu1)
                {
                    Console.WriteLine(j.ToString());
                }

            }

        }
        // Count Age 23 with originality DN
        public int AgeAndOriginSearch(List<Student> stu)
        {
            return stu.Where(stu => stu.Age == 23 && stu.Origin == "DN").Count();
        }
    }
}
