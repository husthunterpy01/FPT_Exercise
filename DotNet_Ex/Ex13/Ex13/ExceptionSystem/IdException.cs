using Ex13.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex13.ExceptionSystem
{
    internal class IdException
    {
        public static string IdInput(List<Employee> employee)
        {
            try
            {
                var id = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(id))
                {
                    throw new ArgumentException("Invalid Id, please try again!");
                }
                if (employee.Any(e => e.Id == id))
                {
                    throw new ArgumentException("Id has already been taken, please try again!");
                }
                return id;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument Exception: {ex.Message}");
                return IdInput(employee); // Recursive call to try again
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                return IdInput(employee); // Recursive call to try again
            }
        }
    }
    }

