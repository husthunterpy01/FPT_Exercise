using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex13.ExceptionSystem
{
    internal class EmailException : IOException
    {
        public EmailException(string messsage) : base(messsage)
        {

        }
        public static string EmailInput()
        {
            var email = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(email) || !email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("Invalid email address, please try again!");
            }
            else
            {
                return email;
            }
        }
    }
}
