using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Hospital_Presentation.GlobalClasses
{
    class clsValidating
    {
        public static bool ValidateDateStringFormat(string dateString)
        {
            string format = "dd/mm/yyyy";

            DateTime dt;
            return DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt );

        }
     
        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(emailAddress);

        }


    }
}
