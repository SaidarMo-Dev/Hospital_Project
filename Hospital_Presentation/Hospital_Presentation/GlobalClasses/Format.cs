using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Presentation.GlobalClasses
{
    class Format
    {
        public static string ConvertDateTimeToStringFormat(DateTime dateTime)
        {
            string dateString = "";

            dateString = dateTime.ToString("dd/mm/yyyy");

            return dateString;

        }
    
        public static string ConvertDateTimeToStringFormat(Nullable <DateTime> dateTime)
        {
            return ConvertDateTimeToStringFormat(Convert.ToDateTime(dateTime));
        }
    }
}
