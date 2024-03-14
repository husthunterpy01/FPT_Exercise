using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex3
{
    internal class ManagerCandidate
    {
        List<Candidate> c = new List<Candidate>();
        Candidate candidate;
        public void ProgramMenu()
        {
            int m;
            Console.WriteLine("~~~~~~~~~~~~~+~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to our system, choose a number to continue");
            do
            {
                m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1. Add candidate information");
                Console.WriteLine("2. Print the information of the candidate");
                Console.WriteLine("3. Search the candidate through the Id");
                Console.WriteLine("4. Exit");
                switch (m)
                {
                    // Add candidate information
                    case 1:
                        Console.WriteLine("You have chosen to add the candidate information");
                        AddCandidate();
                        break;
                    // Print the candidate information
                    case 2:
                        Console.WriteLine("You have chosen to print the information of the candidate");
                        PrintCandidateInfo();
                        break;
                    // Search the candidate through the Id
                    case 3:
                        Console.WriteLine("Search the candidate through the Id");
                        SearchById();
                        break;
                    // Exit the program
                    case 4:
                        break;
                    // Invalid number
                    default:
                        Console.WriteLine("No valid number, please try again");
                        break;
                }
            } while (m != 4);

        }

        // Add the candidate
        public void AddCandidate()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Add the type that the candidate will enroll in (Only A, B or C)");
            string typeCandidate = Console.ReadLine();
            switch (typeCandidate)
            {
                case "A":
                    candidate = new CandidateA();
                    break;
                case "B":
                    candidate = new CandidateB();
                    break;
                case "C":
                    candidate = new CandidateC();
                    break;
                default:
                    Console.WriteLine("No type found, please try again");
                    return;
            }
            Console.WriteLine("Add the Id of the candidate");
            candidate.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add the name of the candidate");
            candidate.Name = Console.ReadLine();
            Console.WriteLine("Add the address of the candidate");
            candidate.Address = Console.ReadLine();
            Console.WriteLine("Add the priority of the candidate");
            candidate.Priority = Convert.ToInt32(Console.ReadLine());
            c.Add(candidate);
        }
        // Print the detail information of the candidate
        public void PrintCandidateInfo()
        {
            foreach (var i in c)
            {
                i.ToString();
            }
        }

        public override string ToString()
        {
            return string.Format($"The id : {candidate.Id} The name: {candidate.Name} The address:{candidate.Address} The priority:{candidate.Priority} Type: {candidate.GetType()}");
        }

        // Search candidate information by id

        public void SearchById()
        {
            int n;
            Console.WriteLine("Enter the id of the candidate");
            n = Convert.ToInt32(Console.ReadLine());
            foreach (var i in c)
            {
                if (n == candidate.Id)
                {
                    i.ToString();
                }
            }

        }

    }
}


