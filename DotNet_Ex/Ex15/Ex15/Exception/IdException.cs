using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Exception
{
    internal class IdException
    {
        public static string ValidateId(List<Student> studentList)
        {
            string id = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Student ID cannot be empty.");
            }

            if (studentList.Exists(s => s.Id == id))
            {
                throw new ArgumentException("Student ID must be unique.");
            }
            else
            {
                return id;
            }
        }
    }
    }

