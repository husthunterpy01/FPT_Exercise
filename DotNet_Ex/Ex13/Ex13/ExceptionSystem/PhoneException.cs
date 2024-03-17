using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Exception
{
    internal class PhoneException : IOException
    {
        public static int PhoneInput()
        {
            var phone = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(phone) || phone.Length != 10)
            {
                throw new ArgumentException("Invalid phone number, please try again !");
            }
            else
            {
                int phoneNum = int.Parse(phone);
                return phoneNum;
            }
        }
    }
}
