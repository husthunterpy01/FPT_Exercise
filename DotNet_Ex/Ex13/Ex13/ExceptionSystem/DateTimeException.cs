using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.ExceptionSystem
{
    internal class DateTimeException
    {
        // Datetime exception
        public static bool TryParseNonStandardDate(string input, out DateTime result)
        {
            if (input.Length != 8)
            {
                result = default(DateTime);
                return false;
            }

            if (!int.TryParse(input.Substring(0, 2), out int day) ||
                !int.TryParse(input.Substring(2, 2), out int month) ||
                !int.TryParse(input.Substring(4, 4), out int year))
            {
                result = default(DateTime);
                return false;
            }

            try
            {
                result = new DateTime(year, month, day);
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                result = default(DateTime);
                return false;
            }
        }
    }
}
