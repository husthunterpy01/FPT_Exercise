using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.ExceptionSystem
{
    internal class FullNameException : IOException
    {
        public static string NameInput()
        {
            var name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name) || name.Length <5)
            {
                throw new ArgumentException("Invalid full name, please try again!");
            }
            else
            {
                return name;
            }
        }
    }
}
